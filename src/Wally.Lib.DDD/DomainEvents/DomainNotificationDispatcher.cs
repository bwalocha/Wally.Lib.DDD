using System.Threading;
using System.Threading.Tasks;

using Wally.Lib.DDD.Abstractions.DomainEvents;
using Wally.Lib.ServiceBus.Abstractions;

namespace Wally.Lib.DDD.DomainEvents;

public class DomainNotificationDispatcher : IDomainNotificationDispatcher
{
	private readonly IBus _bus;

	public DomainNotificationDispatcher(IBus bus)
	{
		_bus = bus;
	}

	public Task DispatchAsync<TDomainEvent>(TDomainEvent domainEvent, CancellationToken cancellationToken)
		where TDomainEvent : DomainEvent
	{
		// TODO: wrap into Notification object?
		return _bus.PubSub.PublishAsync(domainEvent, cancellationToken);
	}
}
