using System.Threading;
using System.Threading.Tasks;

namespace Wally.Lib.DDD.Abstractions.DomainEvents
{
	public interface IDomainEventDispatcher
	{
		Task DispatchAsync<TDomainEvent>(TDomainEvent domainEvent, CancellationToken cancellationToken)
			where TDomainEvent : DomainEvent;
	}
}
