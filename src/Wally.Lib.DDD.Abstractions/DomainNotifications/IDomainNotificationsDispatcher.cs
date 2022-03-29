using System.Threading;
using System.Threading.Tasks;

namespace Wally.Lib.DDD.Abstractions.DomainNotifications;

public interface IDomainNotificationsDispatcher
{
	Task DispatchAsync(CancellationToken cancellationToken);
}
