using System.Threading;
using System.Threading.Tasks;
using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public interface IQueryDispatcher
	{
		Task<TResult> HandleAsync<TQuery, TResult>(TQuery query, CancellationToken cancellationToken)
			where TQuery : IQuery<TResult> where TResult : IResponse;
	}
}
