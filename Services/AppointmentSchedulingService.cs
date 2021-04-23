using DomainEventsConsole.Interfaces;
using DomainEventsConsole.Model;
using System;

namespace DomainEventsConsole.Services
{
    public class AppointmentSchedulingService
    {
        private IRepository<Appointment> _apptRepository;
        public AppointmentSchedulingService(IRepository<Appointment> apptRepository)
        {
            _apptRepository = apptRepository;
        }

        public void ScheduleAppointment(string email, DateTime appointmentTime)
        {
            var appointment = Appointment.Create(email);
            _apptRepository.Save(appointment);
        }
    }
}
