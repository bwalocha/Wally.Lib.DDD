using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Wally.Lib.DDD.Abstractions.DomainEvents;

namespace Wally.Lib.DDD.DomainEvents;

public class DomainEventDispatcher : IDomainEventDispatcher
{
	private readonly IServiceProvider _serviceProvider;

	public DomainEventDispatcher(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
	}

	public async Task DispatchAsync<TDomainEvent>(TDomainEvent domainEvent, CancellationToken cancellationToken)
		where TDomainEvent : DomainEvent
	{
		var domainEvenHandlerType = typeof(IDomainEventHandler<>);
		var domainEvenHandlerTypeWithGenericType = domainEvenHandlerType.MakeGenericType(domainEvent.GetType());

		foreach (dynamic? service in _serviceProvider.GetServices(domainEvenHandlerTypeWithGenericType))
		{
			await service!.HandleAsync((dynamic)domainEvent, cancellationToken);
		}
	}
}
