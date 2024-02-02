using ApiSkeleton.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Tambah Logger
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Posisi middleware extension services ada diatas AddControllers()
builder.Services.AddServiceExtensions();

builder.Services.AddControllers(); 

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

app.Use(async (context, next) =>
{
    Console.WriteLine("logic sebelum next.Invoke() dieksekusi di Use method");
    await next.Invoke();
    Console.WriteLine("logic setelah next.Invoke() dieksekusi di Use method");
});

//menambahkan terminal ke pipeline app
//artinya Run disini selalu dieksekusi setiap melalui pipeline app
app.Run(async context =>
{
    Console.WriteLine("writing response in the Run method");
    await context.Response.WriteAsync("hello from middleware component");
});

app.MapControllers();

app.Run();
