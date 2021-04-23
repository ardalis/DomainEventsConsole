using System;
using DomainEventsConsole.Model;
using DomainEventsConsole.Services;

namespace DomainEventsConsole
{
    public class App
    {
        private readonly AppointmentSchedulingService _appointmentService;

        public App(AppointmentSchedulingService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        public void Run()
        {
            Console.WriteLine("App running.");

            Console.WriteLine("Scheduling an appointment.");
            _appointmentService.ScheduleAppointment("steve@test1.com", DateTime.Now);

            Console.WriteLine("Creating an appointment.");
            var appointment = Appointment.Create("steve@test2.com");
            Console.WriteLine("Confirming an appointment.");
            appointment.Confirm(DateTime.Now);

            Console.WriteLine("Application done.");
            Console.ReadLine();
        }
    }
}
