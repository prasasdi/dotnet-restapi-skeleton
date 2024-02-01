﻿using Contracts;
using LoggerService;

namespace ApiSkeleton.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Add Service Middleware
        /// </summary>
        /// <param name="services"></param>
        public static void AddServiceExtensions(this IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureIISIntegration();
            services.ConfigureLoggerService();
        }

        /**
         * Tambah Logger Service ke IOC Container pakai Singleton
         */
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        /**
         * Yang dilakukan pertama kali adalah mengkonfigurasi CORS (cross-origin resource sharing)
         * CORS adalah mekanisme untuk memberikan hak akses pada aplikasi dari domain-domain yang berbeda
         * 
         * Nanti bisa disesuaikan dengan kebutuhan dengan contoh dibawah:
         * AllowAnyOrigins => WithOrigin("htptps://contoh.com/")
         * AllowAnyMethods => WithMethods("POST", "GET")
         * AllowAnyHeaders => WithHeaders("accept", "content-type")
         * 
         * Karena dari semua domain (1) itu bisa lakuin segala method (2) dengan segala header yang mereka bawa (3) yang artinya membuat
         * API yang kita buat menjadi riskan. Kecuali digunakan dalam satu lingkaran yang sudah ditetapkan terbatas. Bukan open domain-ish
         */
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors( options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        /**
         * Secara default. ASP.NET Core sudah secara default self-hosted. Skeleton ini cukup pake bawaan konfigurasi IIS dari mereka
         */
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
    }
}
