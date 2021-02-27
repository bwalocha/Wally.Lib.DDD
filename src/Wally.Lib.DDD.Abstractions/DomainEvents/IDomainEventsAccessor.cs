using System.Collections.Generic;

namespace Wally.Lib.DDD.Abstractions.DomainEvents
{
	public interface IDomainEventsAccessor
	{
		IReadOnlyCollection<DomainEvent> GetAllDomainEvents();

		void ClearAllDomainEvents();
	}
}
