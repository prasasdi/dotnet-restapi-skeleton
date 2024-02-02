using ApiSkeleton.Extensions;
using Microsoft.AspNetCore.Authentication;
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

//bikin branch terminal baru dengan app.Map() method
app.Map("/usingmapbranch", builder =>
{
    //juga ada method app kayak Use dan Run juga
    builder.Use(async (context, next) =>
    {
        Console.WriteLine("map branch logic in the use method before next delegate");
        await next.Invoke();
        Console.WriteLine("map branch logic in the use method after next delegate");
    });
    builder.Run(async context =>
    {
        Console.WriteLine("map branch response to the client in the run method");
        await context.Response.WriteAsync("hello from the map branch");
    });
});

//bikin branch dimana url ada parameter
app.MapWhen(context => context.Request.Query.ContainsKey("testquerystring"), builder =>
{
    builder.Run(async context =>
    {
        await context.Response.WriteAsync("hello from the mapwhen branch");
    });
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
