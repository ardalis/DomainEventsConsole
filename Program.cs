using System;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using DomainEventsConsole.Services;
using DomainEventsConsole.Repositories;
using DomainEventsConsole.Interfaces;
using DomainEventsConsole;

Console.WriteLine("Load services");

var services = ConfigureServices();

var app = services
            .BuildServiceProvider()
            .GetRequiredService<App>();

await app.Run();


static IServiceCollection ConfigureServices()
{
    IServiceCollection services = new ServiceCollection();

    services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

    services.AddTransient<AppointmentSchedulingService>();
    services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
    services.AddTransient<App>();

    return services;
}
