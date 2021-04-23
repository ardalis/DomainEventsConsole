using System.Threading;
using System.Threading.Tasks;
using DomainEventsConsole.Events;
using MediatR;

namespace DomainEventsConsole.Handlers
{
    public class NotifyUIAppointmentConfirmed : INotificationHandler<AppointmentConfirmed>
    {
        public Task Handle(AppointmentConfirmed notification, CancellationToken cancellationToken)
        {
            ConsoleWriter.FromUIEventHandlers("[UI] User Interface informed appointment for {0} confirmed at {1}",
                notification.Appointment.EmailAddress,
                notification.Appointment.ConfirmationReceivedDate.ToString());

            return Task.CompletedTask;
        }
    }
}