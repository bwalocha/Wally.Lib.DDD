using System.Threading;
using System.Threading.Tasks;

using Wally.Lib.DDD.Abstractions.DomainEvents;

namespace Wally.Lib.DDD.Abstractions.DomainNotifications;

public interface IDomainNotificationDispatcher
{
	Task DispatchAsync<TDomainEvent>(TDomainEvent domainEvent, CancellationToken cancellationToken)
		where TDomainEvent : DomainEvent;
}
