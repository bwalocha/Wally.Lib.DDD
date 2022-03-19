using System;

namespace Wally.Lib.DDD.Abstractions.DomainModels;

public abstract class AggregateRoot : Entity
{
	protected AggregateRoot()
	{
	}

	protected AggregateRoot(Guid id)
		: base(id)
	{
	}
}
