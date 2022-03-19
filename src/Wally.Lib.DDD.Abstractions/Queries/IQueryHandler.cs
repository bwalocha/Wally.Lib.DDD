using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
	where TQuery : IQuery<TResponse> where TResponse : IResponse
{
	Task<TResponse> HandleAsync(TQuery query, CancellationToken cancellationToken);
}
