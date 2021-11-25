using Microsoft.AspNetCore.OData.Query;
using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public abstract class PagedQuery<TResult> : IQuery<PagedResponse<TResult>> where TResult : IResponse
	{
		public ODataQueryOptions QueryOptions { get; }

		public PagedQuery(ODataQueryOptions queryOptions)
		{
			QueryOptions = queryOptions;
		}
	}
}
