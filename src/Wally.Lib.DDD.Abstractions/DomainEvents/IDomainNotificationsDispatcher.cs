using System.Threading;
using System.Threading.Tasks;

namespace Wally.Lib.DDD.Abstractions.DomainEvents;

public interface IDomainNotificationsDispatcher
{
	Task DispatchAsync(CancellationToken cancellationToken);
}
