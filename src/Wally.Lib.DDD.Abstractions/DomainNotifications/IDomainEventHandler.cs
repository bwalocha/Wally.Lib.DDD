using System.Threading;
using System.Threading.Tasks;
using Wally.Lib.DDD.Abstractions.DomainEvents;

namespace Wally.Lib.DDD.Abstractions.DomainNotifications
{
	public interface IDomainNotificationHandler<in TDomainEvent> where TDomainEvent : DomainEvent
	{
		Task HandleAsync(TDomainEvent domainEvent, CancellationToken cancellationToken);
	}
}
