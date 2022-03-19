using System.Threading;
using System.Threading.Tasks;

namespace Wally.Lib.DDD.Abstractions.DomainEvents;

public interface IDomainNotificationDispatcher
{
	Task DispatchAsync<TDomainEvent>(TDomainEvent domainEvent, CancellationToken cancellationToken)
		where TDomainEvent : DomainEvent;
}
