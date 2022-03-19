namespace Wally.Lib.DDD.Abstractions.Commands
{
	public interface ICommand : MediatR.IBaseRequest
	{
	}

	public interface ICommand<out TResult> : ICommand, MediatR.IRequest<TResult>
	{
	}
}
