﻿using IgniteUI.Blazor.Controls;
using KB11775_BlazorWasmApp1;
using KB11775_BlazorWasmApp1.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add services to the container.
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddIgniteUIBlazor(typeof(IgbGridModule));
builder.Services.AddSingleton<ProductsDataService>();

await builder.Build().RunAsync();
