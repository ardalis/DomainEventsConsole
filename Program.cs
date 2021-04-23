using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DomainEventsConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Load services");
            var services = ConfigureServices();

            var app = services
                        .BuildServiceProvider()
                        .GetRequiredService<App>();

            app.Run();

        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<App>();

            return services;
        }
    }

    public class App
    {
        public void Run()
        {
            Console.WriteLine("App running.");
        }
    }
}
