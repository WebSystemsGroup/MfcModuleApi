using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Utils
{
    public static class DataUtils
    {
        private const string PasswordHash = "a0f7229c";
        private const string SaltKey = "14940ee1";
        private const string ViKey = "04a4a14f1d8c4e46";

        public static string SoftwareDir => AppDomain.CurrentDomain.BaseDirectory;
        public static async Task<string> Encrypt(string plainText)
        {
            try
            {
                if (ValidationUtils.IsValidName(plainText)) return null;
                var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                MemoryStream memoryStream = new();
                RijndaelManaged symmetricKey = new() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };

                var keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
                var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(ViKey));
                
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

        public static async Task<string> Decrypt(string encryptedText)
        {
            try
            {
                if (ValidationUtils.IsValidName(encryptedText)) return null;
                var cipherTextBytes = Convert.FromBase64String(encryptedText);
                MemoryStream memoryStream = new(cipherTextBytes);
                var keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
                RijndaelManaged symmetricKey = new() { Mode = CipherMode.CBC, Padding = PaddingMode.None };
                var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(ViKey));
                CryptoStream cryptoStream = new(memoryStream, decryptor, CryptoStreamMode.Read);
                var plainTextBytes = new byte[cipherTextBytes.Length];
                var decryptedByteCount = await cryptoStream.ReadAsync(plainTextBytes.AsMemory(0, plainTextBytes.Length));

                await cryptoStream.DisposeAsync();
                await memoryStream.DisposeAsync();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)
                               .TrimEnd("\0".ToCharArray());
            }
            catch
            {
                return null;
            }
        }
    }
}
