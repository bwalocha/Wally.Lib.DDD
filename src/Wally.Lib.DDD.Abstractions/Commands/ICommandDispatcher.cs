using System.Threading;
using System.Threading.Tasks;

namespace Wally.Lib.DDD.Abstractions.Commands;

public interface ICommandDispatcher
{
	Task HandleAsync<TCommand>(TCommand command, CancellationToken cancellationToken) where TCommand : ICommand;

	Task<TResult> HandleAsync<TCommand, TResult>(TCommand command, CancellationToken cancellationToken)
		where TCommand : ICommand<TResult>;
}
