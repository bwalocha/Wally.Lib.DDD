using System.Threading;
using System.Threading.Tasks;

using Wally.Lib.DDD.Abstractions.DomainEvents;

namespace Wally.Lib.DDD.DomainEvents;

public class DomainEventsDispatcher : IDomainEventsDispatcher
{
	private readonly IDomainEventDispatcher _domainEventDispatcher;
	private readonly IDomainEventsAccessor _domainEventsAccessor;

	public DomainEventsDispatcher(
		IDomainEventsAccessor domainEventsAccessor,
		IDomainEventDispatcher domainEventDispatcher)
	{
		_domainEventsAccessor = domainEventsAccessor;
		_domainEventDispatcher = domainEventDispatcher;
	}

	public async Task DispatchAsync(CancellationToken cancellationToken)
	{
		var domainEvents = _domainEventsAccessor.GetAllDomainEvents();

		foreach (var domainEvent in domainEvents)
		{
			await _domainEventDispatcher.DispatchAsync(domainEvent, cancellationToken);
		}
	}
}
