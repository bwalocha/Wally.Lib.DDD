using Microsoft.AspNetCore.OData.Query;
using Wally.Lib.DDD.Abstractions.Requests;
using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public abstract class ODataQuery<TRequest, TResponse> : IODataQuery<TRequest, ODataResponse<TResponse>> 
		where TRequest : IRequest
		where TResponse : IResponse
	{
		public ODataQueryOptions<TRequest> QueryOptions { get; }

		public ODataQuery(ODataQueryOptions<TRequest> queryOptions)
		{
			QueryOptions = queryOptions;
		}
	}
}
