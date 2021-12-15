using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DataLayer.Settings;
using Microsoft.AspNetCore.Http;

namespace DataLayer.ExceptionMiddleware
{
    internal class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionMessageAsync(context, ex).ConfigureAwait(false);
            }
        }

        private static async Task HandleExceptionMessageAsync(HttpContext context, Exception exception)
        {
            var request = FormatRequest(context.Request);

            const int statusCode = StatusCodes.Status500InternalServerError;
            var result = JsonSerializer.Serialize(new
            {
                StatusCode = statusCode,
                ErrorMessage = exception.Message
            });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;
            await context.Response.WriteAsync(result);
        }
        private static string FormatRequest(HttpRequest request)
        {
            List<RequestSetting> requestData = new();

            if (request.HasFormContentType)
            {
                requestData.AddRange( request.Form.Select(s => new RequestSetting(s.Key, s.Value )).ToList());
            }

            if (request.QueryString.HasValue)
            {
                requestData.AddRange(request.Query.Select(s => new RequestSetting( s.Key, s.Value )).ToList());
            }
            return JsonSerializer.Serialize(requestData);
        }
    }
}
