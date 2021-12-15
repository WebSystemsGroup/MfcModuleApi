using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using DataLayer.Settings;
using DataLayer.Utils;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace DataLayer.JWT
{
    internal class JwtToken : IJwtToken
    {
        private readonly JwtSettings _jwt;
        public JwtToken(IOptions<JwtSettings> jwt)
        {
            _jwt = jwt.Value;
        }

        /// <summary>
        /// Генерация токена
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public string GenerateAccessToken(Guid employeeId)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, employeeId.ToString())
            };

            return new JwtSecurityTokenHandler()
                .WriteToken(new JwtSecurityToken(
                    _jwt.Issuer,
                    _jwt.Audience,
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(_jwt.AccessTokenLifeTime),
                    signingCredentials: new SigningCredentials(_jwt.GetSymmetricSecurityKey(),
                        SecurityAlgorithms.HmacSha256Signature)
                ));
        }

        /// <summary>
        /// Создать объект хранящий информацию об авторизованном пользователе
        /// </summary>
        /// <param name="token">Токен</param>
        /// <returns></returns>
        public Guid CreateAuthenticatedUserInfo(string token) => Guid.Parse(new JwtSecurityToken(token).Claims.First(f => f.Type == ClaimTypes.NameIdentifier).Value);
        
        /// <summary>
        /// Генерация рефреш токена
        /// </summary>
        /// <returns>Рефреш токен</returns>
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            new RNGCryptoServiceProvider().GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        /// <summary>
        /// Проверка валидности токена
        /// </summary>
        /// <param name="token"></param>
        public bool ValidateToken(string token)
        {
            new JwtSecurityTokenHandler().ValidateToken(token, CreateTokenValidationParameters(), out var scr);
            return scr is not null;
        }

        /// <summary>
        /// Параметры валидации токена
        /// </summary>
        /// <returns></returns>
        private TokenValidationParameters CreateTokenValidationParameters() =>
            new()
            {
                ValidateIssuerSigningKey = true,
                ValidateLifetime = false,
                IssuerSigningKey = _jwt.GetSymmetricSecurityKey(),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };
    }
}
