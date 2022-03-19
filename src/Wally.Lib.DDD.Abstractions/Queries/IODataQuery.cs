using Microsoft.AspNetCore.OData.Query;
using Wally.Lib.DDD.Abstractions.Requests;
using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public interface IODataQuery<TRequest, out TResponse> : IQuery<TResponse> 
		where TRequest : IRequest
		where TResponse : IResponse
	{
		ODataQueryOptions<TRequest> QueryOptions { get; }
	}
}
