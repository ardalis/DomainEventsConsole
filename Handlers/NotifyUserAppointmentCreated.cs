using System.Threading;
using System.Threading.Tasks;
using DomainEventsConsole.Events;
using MediatR;

namespace DomainEventsConsole.Handlers
{
    public class NotifyUserAppointmentCreated : INotificationHandler<AppointmentCreated>
    {
        public Task Handle(AppointmentCreated notification, CancellationToken cancellationToken)
        {
            string emailAddress = notification.Appointment.EmailAddress;
            ConsoleWriter.FromEmailEventHandlers("[EMAIL] Notification email sent to {0}", emailAddress);

            return Task.CompletedTask;
        }
    }


}