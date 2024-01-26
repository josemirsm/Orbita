using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.AspNetCore.Http.Connections;
using MudBlazor.Services;
using Orbita.Cash.Data;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

OrbitaKey.Data.MyContext.isMigration = false;

OrbitaKey.Data.MyContext.bancoSchema = "hospedai_testedb";

OrbitaKey.Data.MyContext.bancoHost = "66.94.109.0";
OrbitaKey.Data.MyContext.bancoPort = "3306";
OrbitaKey.Data.MyContext.bancoUser = "hospedai_teste";
OrbitaKey.Data.MyContext.bancoPass = "@userTeste";

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
};

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub(configureOptions: options =>
{
    options.Transports = HttpTransportType.WebSockets | HttpTransportType.LongPolling;
});

app.MapFallbackToPage("/_Host");

app.Run();