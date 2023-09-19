using EFCoreMigrationsDemo.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

var builder = new HostBuilder()
    .ConfigureServices((hostContext, services) => {
        services.AddDbContext<BloggingContext>(options => 
            options.UseSqlServer(hostContext.Configuration.GetConnectionString("DefaultConnectionString")));
    })
    .ConfigureAppConfiguration((hostingContext, config) => {
        config.SetBasePath(Directory.GetCurrentDirectory());
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    });

var host = builder.Build();

await host.RunAsync();