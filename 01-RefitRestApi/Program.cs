using _01_RefitRestApi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Refit;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) => {
        services.AddRefitClient<IUsersClient>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/"));

        services.AddLogging(builder => {
            builder.AddConsole();
            builder.AddDebug();
        });
    }).Build();

await new App().Start(host);
