using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.FileReader;
using Blazored.LocalStorage;
using KanbaneManager.BlazorApp.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Radzen;

namespace KanbaneManager.BlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            var URL = "https://localhost:44327";
            builder.Services.AddScoped<AuthenticationService>(s =>
            {
                return new AuthenticationService(URL);
            });
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddFileReaderService(options =>
            {
                options.UseWasmSharedBuffer = true;
            }); 
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(URL) });
            builder.Services.AddScoped<AuthenticationStateProvider, LocalAuthenticationStateProvider>();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();
            builder.RootComponents.Add<App>("app");
            await builder.Build().RunAsync();
        }
    }
}
