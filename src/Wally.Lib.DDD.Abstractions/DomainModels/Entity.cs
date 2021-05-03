using System;
using System.Collections.Generic;
using Wally.Lib.DDD.Abstractions.DomainEvents;
using Wally.Lib.DDD.Abstractions.Validators;

namespace Wally.Lib.DDD.Abstractions.DomainModels
{
	public abstract class Entity : IEntity<Guid>
	{
		private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();

		protected Entity()
			: this(Guid.NewGuid())
		{
		}

		protected Entity(Guid id)
		{
			Id = id;
		}

		public IReadOnlyCollection<DomainEvent> GetDomainEvents() => _domainEvents.AsReadOnly();

		public virtual Guid Id { get; private set; }

		protected void AddDomainEvent(DomainEvent domainEvent)
		{
			_domainEvents.Add(domainEvent);
		}

		public void RemoveDomainEvent(DomainEvent domainEvent)
		{
			_domainEvents.Remove(domainEvent);
		}

		// TODO: Consider check list of rules
		protected static void CheckRule(IBusinessRule rule)
		{
			if (rule.IsBroken())
			{
				// TODO: 
				// throw new DomainValidationException(rule);

				throw new NotImplementedException();
			}
		}
	}
}
