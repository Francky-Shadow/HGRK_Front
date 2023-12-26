using hgrkapp;
using hgrkapp.DTO;
using hgrkapp.Repository.IServices;
using hgrkapp.Repository.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton<universite>();
builder.Services.AddSingleton<groupe>();
builder.Services.AddSingleton<stage>();
builder.Services.AddScoped<IUniversiteServices,UniversiteServices>();
builder.Services.AddScoped<IStageService,StageService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
