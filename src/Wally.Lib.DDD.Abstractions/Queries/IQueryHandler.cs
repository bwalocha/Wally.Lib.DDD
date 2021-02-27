using System.Threading;
using System.Threading.Tasks;
using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery<TResult> where TResult : IResponse
	{
		Task<TResult> HandleAsync(TQuery query, CancellationToken cancellationToken);
	}
}
