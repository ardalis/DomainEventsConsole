using MediatR;

namespace DomainEventsConsole.Interfaces
{
    public interface IHandle<TEvent> : INotificationHandler<TEvent>
        where TEvent : IDomainEvent
    {
        // Task Handle(TNotification notification, CancellationToken cancellationToken);
    }
}
