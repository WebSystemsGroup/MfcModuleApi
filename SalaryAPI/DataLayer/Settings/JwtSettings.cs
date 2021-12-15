using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace DataLayer.Settings
{
    public class JwtSettings
    {
        /// <summary>
        /// Значение ключа
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Издатель токена
        /// </summary>
        public string Issuer { get; set; }
        /// <summary>
        /// Потребитель токена
        /// </summary>
        public string Audience { get; set; }
        /// <summary>
        /// Время жизни токена в минутах
        /// </summary>
        public int AccessTokenLifeTime { get; set; }
        /// <summary>
        /// Время жизни токена обновления в днях
        /// </summary>
        public int RefreshTokenLifeTime { get; set; }

        public SymmetricSecurityKey GetSymmetricSecurityKey() => new(Encoding.ASCII.GetBytes(Key));


    }
}
