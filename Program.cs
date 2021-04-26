using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using DomainEventsConsole.Services;
using DomainEventsConsole.Repositories;
using DomainEventsConsole.Interfaces;

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

            await app.Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddMediatR(typeof(Program));
            services.AddTransient<AppointmentSchedulingService>();
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<App>();

            return services;
        }
    }

}
