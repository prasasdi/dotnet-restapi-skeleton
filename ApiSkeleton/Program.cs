using ApiSkeleton.Extensions;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Tambah Logger
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Posisi middleware extension services ada diatas AddControllers()
builder.Services.AddServiceExtensions();

// Register repositoryContext at runtime
builder.Services.ConfigurePostgreSQLContext(builder.Configuration);

/**
 * Dengan ditambahnya .Presentation, MainProject (atau ApiSkeleton yang saya kasih nama) disini hanya berfokus menjadi 'kernel' aplikasi saja
 * Perlu ditambah .AddApplicationPart dan mengarahkan ke x.Presentation
 * 
 * Karena nantinya API akan mencari controller hanya didalam x.Presentation
 */
builder.Services.AddControllers()
    .AddApplicationPart(typeof(ApiSkeleton.Presentation.AssemblyReference).Assembly); 

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
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
