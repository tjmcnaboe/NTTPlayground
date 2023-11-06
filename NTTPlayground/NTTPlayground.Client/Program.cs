using ClientModel;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NTTPlayground.Client;
using NTTPlayground.Client.EntityObjectServices;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

builder.Services
    .AddRefitClient<IFacilityDtoHttpService>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress + "api/facilitydto"));
builder.Services.AddScoped<IFacilityDtoEntityService, FacilityDtoHttpApiService>();

await builder.Build().RunAsync();
