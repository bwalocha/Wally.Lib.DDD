using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public interface IQuery<TResult> where TResult : IResponse
	{
	}
}
