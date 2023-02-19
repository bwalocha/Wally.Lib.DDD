using System.Threading;
using System.Threading.Tasks;

using MediatR;

namespace Wally.Lib.DDD.Abstractions.Commands;

public abstract class CommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : ICommand, IRequest
{
	public abstract Task HandleAsync(TCommand command, CancellationToken cancellationToken);

	public Task Handle(TCommand command, CancellationToken cancellationToken)
	{
		return HandleAsync(command, cancellationToken);
	}
}
