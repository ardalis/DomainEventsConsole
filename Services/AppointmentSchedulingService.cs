using DomainEventsConsole.Interfaces;
using DomainEventsConsole.Model;
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

        public Task ScheduleAppointment(string email)
        {
            var appointment = Appointment.Create(email);
            return _apptRepository.Save(appointment);
        }
    }
}
