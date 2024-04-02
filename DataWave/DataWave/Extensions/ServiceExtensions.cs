using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using NLog;
using Contracts;




namespace DataWave.Extensions

{
public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder => builder
                // .WithOrigins("http://www.skillstorm.com")
                .AllowAnyOrigin()
                // .WithMethods("POST", "PUT", "DELETE", "GET")
                .AllowAnyMethod()
                // .WithHeaders("accept", "content-type")
                .AllowAnyHeader());
        });
    public static void ConfigureIISIntegration(this IServiceCollection services) =>
     services.Configure<IISOptions>(options =>
     {

     });

    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();
}
}
