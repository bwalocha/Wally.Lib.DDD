using MediatR;

namespace Wally.Lib.DDD.Abstractions.Commands;

public interface ICommand : IRequest<Unit>
{
}

public interface ICommand<out TResult> : IRequest<TResult>
{
}
