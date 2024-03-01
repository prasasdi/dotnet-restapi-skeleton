using ApiSkeleton.Formatters;
using Contracts;
using Contracts.Repository.Manager;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Manager;
using Service.Contracts.Manager;
using Services.Manager;
using System.ComponentModel;

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

            services.ConfigureRepositoryManager();
            services.ConfigureServiceManager();
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

        /**
         * Menambahkan repository, lapisan service yang menangani domain dengan cara menambahkan RepositoryManager pada kontainer
         * Bukan pada domain repository masing-masing.
         * 
         * Jika ada penambahan domain, sertakan juga repository domain pada RepositoryManager
         */
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        /**
         * Menambahkan services, lapisan service yang menangani domain dengan cara menambahkan ServiceManager pada kontainer
         * Bukan pada domain service masing-masing.
         * 
         * Jika ada penambahan domain, sertakan juga service domain pada ServiceManager
         */
        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigurePostgreSQLContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
                opts.UseNpgsql(configuration.GetConnectionString("sqlconnection")));

        // kalau mau tambah, nanti diganti nama fungsinya jadi apa
        public static IMvcBuilder AddCustomCSVFormatter(this IMvcBuilder builder) =>
            builder.AddMvcOptions(config => config.OutputFormatters.Add(new CsvOutputFormatter()));
    }
}
