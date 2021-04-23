using DomainEventsConsole.Interfaces;
using DomainEventsConsole.Model;
using System;
using System.Threading.Tasks;

namespace DomainEventsConsole.Services
{
    public class AppointmentSchedulingService
    {
        private IRepository<Appointment> _apptRepository;
        public AppointmentSchedulingService(IRepository<Appointment> apptRepository)
        {
            _apptRepository = apptRepository;
        }

        public async Task ScheduleAppointment(string email, DateTime appointmentTime)
        {
            var appointment = Appointment.Create(email);
            await _apptRepository.Save(appointment);
        }
    }
}
