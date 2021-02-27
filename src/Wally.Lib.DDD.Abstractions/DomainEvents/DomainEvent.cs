using System;

namespace Wally.Lib.DDD.Abstractions.DomainEvents
{
	public abstract class DomainEvent
	{
		public DateTime OccuredOnUtc { get; } = DateTime.UtcNow;
	}
}
