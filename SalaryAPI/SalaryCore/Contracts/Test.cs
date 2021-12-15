using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Utils;

namespace SalaryCore.Common
{
    internal class Test
    {
        //private const string PasswordHash = "a0f7229c";
        //private const string SaltKey = "14940ee1";
        //private const string ViKey = "04a4a14f1d8c4e46";
        private const string Value = "a0f7229c";

        /// <summary>
        /// Генерация токена JWE
        /// </summary>
        /// <param name="claims"></param>
        /// <returns></returns>
        private static string GenerateAccessToken(IEnumerable<Claim> claims)
        {
            
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            JwtSecurityToken token = new JwtSecurityTokenHandler().CreateJwtSecurityToken(
                "",
                "",

                new ClaimsIdentity(claims),
                null,
                DateTime.UtcNow.AddMinutes(60),
                null,
                new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes("Key")),
                    SecurityAlgorithms.HmacSha256Signature),
                encryptingCredentials: new EncryptingCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")), JwtConstants.DirectKeyUseAlg,
                    SecurityAlgorithms.Aes128CbcHmacSha256)
            );
            return tokenHandler.WriteToken(token);
        }

        public static string EnCrypt(string sours)
        {
            var hash =Encrypt1(sours);
            return hash;
        }
        
        private static string Encrypt1(string plainText)
        {
            if (ValidationUtils.IsValidName(plainText)) return null;
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            SymmetricAlgorithm symmetricKey = Rijndael.Create();
            
            var encryptor = symmetricKey.CreateEncryptor(new PasswordDeriveBytes(Value, null).GetBytes(8), new byte[16]);

            var memoryStream = new MemoryStream();
            
            var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            cryptoStream.Dispose();


            return Convert.ToBase64String(memoryStream.ToArray());
        }



        public static async Task<string> Encrypt(string plainText)
        {
            try
            {
                if (ValidationUtils.IsValidName(plainText)) return null;
                var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                MemoryStream memoryStream = new();

                RijndaelManaged symmetricKey = new() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
                
                var encryptor = symmetricKey.CreateEncryptor(new PasswordDeriveBytes(Value, null).Salt, new byte[16]);
                
                CryptoStream cryptoStream = new(memoryStream, encryptor, CryptoStreamMode.Write);
                await cryptoStream.WriteAsync(plainTextBytes.AsMemory(0, plainTextBytes.Length));
                await cryptoStream.FlushFinalBlockAsync();
                await cryptoStream.DisposeAsync();

                return Convert.ToBase64String(memoryStream.ToArray());
            }
            catch
            {
                return null;
            }
        }


    }
}
