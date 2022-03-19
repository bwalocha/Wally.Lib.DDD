using MediatR;

namespace Wally.Lib.DDD.Abstractions.Commands;

public interface ICommand : IRequest
{
}

public interface ICommand<out TResult> : IRequest<TResult>
{
}
