using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using MiniProject;

namespace MiniProject
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("#app");
      builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
      builder.Services.AddSingleton<ProfileState>();
      builder.Services.AddSingleton<CatState>();
      builder.Services.AddSingleton<Formatter>();
      builder.Services.AddSingleton<LinesCurrentState>();
      builder.Services.AddSingleton<LinesClickState>();
      builder.Services.AddSingleton<LinesIdleState>();
      builder.Services.AddSingleton<UpgradesState>();
      builder.Services.AddBlazoredLocalStorage(config =>
      {
        config.JsonSerializerOptions.WriteIndented = true;
      });
      await builder.Build().RunAsync();
    }
  }
}