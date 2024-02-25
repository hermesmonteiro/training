﻿using Mooda.Host.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Mooda.Host.Extensions
{
    public static class MiddlewareRegistrationExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder app,
                                                        IWebHostEnvironment env)
        {
            app.UseMiddleware<HttpLoggingMiddleware>();
            app.UseMiddleware<ErrorHandlerMiddleware>();

            return app;
        }
    }
}