namespace Wally.Lib.DDD.Abstractions.Commands
{
	public interface ICommand
	{
	}

	public interface ICommand<TResult> : ICommand
	{
	}
}
