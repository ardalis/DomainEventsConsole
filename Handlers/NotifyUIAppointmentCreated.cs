using System.Threading;
using System.Threading.Tasks;
using DomainEventsConsole.Events;
using MediatR;

namespace DomainEventsConsole.Handlers
{
    public class NotifyUIAppointmentCreated : INotificationHandler<AppointmentCreated>
    {
        public Task Handle(AppointmentCreated notification, CancellationToken cancellationToken)
        {
            string emailAddress = notification.Appointment.EmailAddress;
            ConsoleWriter.FromUIEventHandlers("[UI] User Interface informed appointment created for {0}", emailAddress);
            return Task.CompletedTask;
        }
    }


}