using System.Threading;
using System.Threading.Tasks;

using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries;

public interface IQueryDispatcher
{
	Task<TResponse> HandleAsync<TQuery, TResponse>(TQuery query, CancellationToken cancellationToken)
		where TQuery : IQuery<TResponse> where TResponse : IResponse;
}
