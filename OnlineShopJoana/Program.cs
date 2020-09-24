using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using OnlineShopJoana.WEB.Data;
using System;

namespace OnlineShopJoana.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            RunSeeding(host);
            host.Run();
        }

        private static void RunSeeding(IWebHost host)
        {
            //Design Pattern / serviço 
           var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope())// precisamos de criar um IOC pro seedDB
            {
               
                var seeder = scope.ServiceProvider.GetService<SeedDB>();
                seeder.SeedAsync().Wait();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>(); // Ioc a trabalhar
        // este startup vai buscar a injeçao ao startup aqui: ( services.AddTransient<SeedDB>();  )
    }
}
