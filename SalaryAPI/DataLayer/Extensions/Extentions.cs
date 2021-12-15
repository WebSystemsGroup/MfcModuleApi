using DataLayer.Abstract;
using DataLayer.Entities.Models;
using DataLayer.JWT;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Security.Claims;
using DataLayer.ExceptionMiddleware;

namespace DataLayer.Extensions
{
    public static class Extensions
    {
        public static void UseExceptionHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
        public static void AddJwtToken(this IServiceCollection services)
        {
            services.AddScoped<IJwtToken, JwtToken>();
        }
        public static void AddRepositoty(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
        }

        public static Guid GetUserId(this ClaimsPrincipal claimsPrincipal) =>
            (from claim in claimsPrincipal.Claims where claim.Type == ClaimTypes.NameIdentifier select Guid.Parse(claim.Value)).FirstOrDefault();

        public static bool IsExpired(this RefreshToken refreshToken) => refreshToken.ExpireTime <= DateTime.UtcNow;

        public static bool IsValidIdentifier(this Guid id) => id != Guid.Empty;
        public static bool IsValidIdentifier(this int id) => id > 0;
        public static bool IsValidIdentifier(this string id) => id is not null or { Length: > 0 } && !id.All(a => a is ' ');
    }
}
