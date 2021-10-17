using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Wally.Lib.DDD.Abstractions.Commands;
using Wally.Lib.DDD.Abstractions.Managers;

namespace Wally.Lib.DDD.Commands
{
	public class CommandDispatcher : ICommandDispatcher
	{
		private readonly IPersistenceManager _persistenceManager;
		private readonly IServiceProvider _serviceProvider;

		public CommandDispatcher(IServiceProvider serviceProvider, IPersistenceManager persistenceManager)
		{
			_serviceProvider = serviceProvider;
			_persistenceManager = persistenceManager;
		}

		public async Task HandleAsync<TCommand>(TCommand command, CancellationToken cancellationToken)
			where TCommand : ICommand
		{
			var service = _serviceProvider.GetRequiredService<ICommandHandler<TCommand>>();
			await service.HandleAsync(command, cancellationToken);
			await _persistenceManager.SaveChangesAsync(cancellationToken);
		}

		public async Task<TResult> HandleAsync<TCommand, TResult>(TCommand command, CancellationToken cancellationToken)
			where TCommand : ICommand<TResult>
		{
			var service = _serviceProvider.GetRequiredService<ICommandHandler<TCommand, TResult>>();
			var result = await service.HandleAsync(command, cancellationToken);
			await _persistenceManager.SaveChangesAsync(cancellationToken);

			return result;
		}
	}
}
