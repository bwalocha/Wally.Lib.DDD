using Microsoft.AspNetCore.OData.Query;
using Wally.Lib.DDD.Abstractions.Requests;
using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public abstract class PagedQuery<TResponse> : IQuery<PagedResponse<TResponse>> where TResponse : IResponse
	{
		public PagedQuery()
			: this(new PageInfoQuery())
		{
		}

		public PagedQuery(PageInfoQuery pageInfo)
		{
			PageInfo = pageInfo;
		}

		public PagedQuery(int pageIndex, int pageSize)
			: this(new PageInfoQuery(pageIndex, pageSize))
		{
		}

		public PageInfoQuery PageInfo { get; }
	}

	public abstract class PagedQuery<TRequest, TResponse> : IODataQuery<TRequest, PagedResponse<TResponse>>
		where TRequest : IRequest where TResponse : IResponse
	{
		public ODataQueryOptions<TRequest> QueryOptions { get; }

		public PagedQuery(ODataQueryOptions<TRequest> queryOptions)
		{
			QueryOptions = queryOptions;
		}
	}
}
