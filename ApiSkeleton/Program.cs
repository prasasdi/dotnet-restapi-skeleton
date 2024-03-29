using ApiSkeleton.Extensions;
using Contracts;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Diagnostics.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Tambah Logger
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Posisi middleware extension services ada diatas AddControllers()
builder.Services.AddServiceExtensions();

// Register repositoryContext at runtime
builder.Services.ConfigurePostgreSQLContext(builder.Configuration);

// add maper into application
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

/**
 * Dengan ditambahnya .Presentation, MainProject (atau ApiSkeleton yang saya kasih nama) disini hanya berfokus menjadi 'kernel' aplikasi saja
 * Perlu ditambah .AddApplicationPart dan mengarahkan ke x.Presentation
 * 
 * Karena nantinya API akan mencari controller hanya didalam x.Presentation
 */
builder.Services.AddControllers(config => {
    config.RespectBrowserAcceptHeader = true;
    config.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters()
//.AddCustomCSVFormatter()
.AddApplicationPart(typeof(ApiSkeleton.Presentation.AssemblyReference).Assembly); 

var app = builder.Build();
var logger = app.Services.GetRequiredService<ILoggerManager>();
app.ConfigureExceptionHandler(logger);

if (app.Environment.IsProduction())
    app.UseHsts();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
