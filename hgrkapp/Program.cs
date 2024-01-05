using Blazored.LocalStorage;
using HGRK.Repository.Services;

//using HGRK.Repository.Services;
using hgrkapp;
using hgrkapp.DTO;
using hgrkapp.Helper;
using hgrkapp.Repository.IServices;
using hgrkapp.Repository.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton<universite>();
builder.Services.AddSingleton<groupe>();
builder.Services.AddSingleton<stage>();
builder.Services.AddSingleton<etudiant>();
builder.Services.AddSingleton<User>();
builder.Services.AddSingleton<EtudiantMixedDto>();
builder.Services.AddSingleton<UniversiteStageDto>();
builder.Services.AddSingleton<paiement>();
builder.Services.AddSingleton<departement>();

builder.Services.AddSingleton<SearchStudentResultDto>();

builder.Services.AddScoped<IDepartementServices,DepartementServices>();
builder.Services.AddScoped<IUniversiteServices,UniversiteServices>();
builder.Services.AddScoped<IStageService,StageService>();
builder.Services.AddScoped<IGroupeServices,GroupeService>();
builder.Services.AddSingleton<PaiementMixedDto>();
builder.Services.AddScoped<IEtudiantServices,EtudiantServices>();
builder.Services.AddScoped<IMixedServices, MixedServices>();
builder.Services.AddScoped<IPaiementServices,PaiementServices>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<ISearchServices,SearchServices>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddApiAuthorization();
await builder.Build().RunAsync();
