using System;
using System.Collections.Generic;
using System.Linq;

using Wally.Lib.DDD.Abstractions.DomainEvents;
using Wally.Lib.DDD.Abstractions.DomainModels;
using Wally.Lib.DDD.Abstractions.Managers;

namespace Wally.Lib.DDD.DomainEvents;

public class DomainEventsAccessor : IDomainEventsAccessor
{
	private readonly IPersistenceManager _persistenceManager;

	public DomainEventsAccessor(IPersistenceManager persistenceManager)
	{
		_persistenceManager = persistenceManager;
	}

	public IReadOnlyCollection<DomainEvent> GetAllDomainEvents()
	{
		var domainEntities = GetEntities();

		return domainEntities.SelectMany(x => x.GetDomainEvents())
			.ToList()
			.AsReadOnly();
	}

	public void ClearAllDomainEvents()
	{
		throw new NotImplementedException();
	}

	private IEnumerable<Entity> GetEntities()
	{
		return _persistenceManager.GetEntities()
			.Where(
				e => e.GetDomainEvents()
					.Any());
	}
}
