using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazorBootstrap();

builder.Services.AddScoped(sp =>
	new HttpClient
	{
		BaseAddress = new Uri("https://localhost:7184")
	});

await builder.Build().RunAsync();
