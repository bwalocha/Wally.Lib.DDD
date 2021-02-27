using System.Threading;
using System.Threading.Tasks;
using Wally.Lib.DDD.Abstractions.DomainEvents;

namespace Wally.Lib.DDD.DomainEvents
{
	public class DomainNotificationsDispatcher : IDomainNotificationsDispatcher
	{
		private readonly IDomainEventsAccessor _domainEventsAccessor;
		private readonly IDomainNotificationDispatcher _domainNotificationDispatcher;

		public DomainNotificationsDispatcher(
			IDomainEventsAccessor domainEventsAccessor,
			IDomainNotificationDispatcher domainNotificationDispatcher)
		{
			_domainEventsAccessor = domainEventsAccessor;
			_domainNotificationDispatcher = domainNotificationDispatcher;
		}

		public async Task DispatchAsync(CancellationToken cancellationToken)
		{
			var domainEvents = _domainEventsAccessor.GetAllDomainEvents();

			foreach (var domainEvent in domainEvents)
			{
				await _domainNotificationDispatcher.DispatchAsync(domainEvent, cancellationToken);
			}
		}
	}
}
