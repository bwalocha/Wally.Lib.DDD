using System.Threading;
using System.Threading.Tasks;

namespace Wally.Lib.DDD.Abstractions.DomainEvents
{
	public interface IDomainEventHandler<in TDomainEvent> where TDomainEvent : DomainEvent
	{
		Task HandleAsync(TDomainEvent domainEvent, CancellationToken cancellationToken);
	}
}
