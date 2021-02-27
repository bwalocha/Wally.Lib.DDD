namespace Wally.Lib.DDD.Abstractions.Validators
{
	public interface IBusinessRule
	{
		string Message { get; }

		bool IsBroken();
	}
}
