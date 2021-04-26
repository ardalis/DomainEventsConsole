using System;
using System.Threading.Tasks;
using DomainEventsConsole.Interfaces;
using DomainEventsConsole.Model;
using DomainEventsConsole.Services;

namespace DomainEventsConsole
{
    public class App
    {
        private readonly AppointmentSchedulingService _appointmentService;
        private readonly IRepository<Appointment> _appointmentRepository;

        public App(AppointmentSchedulingService appointmentService,
            IRepository<Appointment> appointmentRepository)
        {
            _appointmentService = appointmentService;
            _appointmentRepository = appointmentRepository;
        }

        public async Task Run()
        {
            var testDate = new DateTime(2030, 9, 9, 14, 0, 0);
            Console.WriteLine("App running.");

            Console.WriteLine("Scheduling an appointment with a service.");
            await _appointmentService.ScheduleAppointment("steve@test1.com");
            Console.WriteLine();

            Console.WriteLine("Creating an appointment with a repository.");
            var appointment = Appointment.Create("steve@test2.com");
            await _appointmentRepository.Save(appointment);
            Console.WriteLine();

            Console.WriteLine("Confirming an appointment.");
            appointment.Confirm(testDate);
            await _appointmentRepository.Save(appointment);
            Console.WriteLine();

            Console.WriteLine("Application done.");
            Console.ReadLine();
        }
    }
}
