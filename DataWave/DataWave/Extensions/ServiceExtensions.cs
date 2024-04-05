using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using NLog;
using Contracts;
using Repository;
using Service.Contracts;
using Service;






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

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureServiceManager(this IServiceCollection services) =>
           services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }
}
