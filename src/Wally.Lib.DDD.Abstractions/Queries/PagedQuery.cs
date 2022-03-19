using Microsoft.AspNetCore.OData.Query;

using Wally.Lib.DDD.Abstractions.Requests;
using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries;

public abstract class PagedQuery<TResponse> : IQuery<PagedResponse<TResponse>> where TResponse : IResponse
{
	public PagedQuery()
		: this(new PageInfo())
	{
	}

	public PagedQuery(PageInfo page)
	{
		Page = page;
	}

	public PagedQuery(int pageIndex, int pageSize)
		: this(new PageInfo(pageIndex, pageSize))
	{
	}

	public PageInfo Page { get; }
}

public abstract class PagedQuery<TRequest, TResponse> : IODataQuery<TRequest, PagedResponse<TResponse>>
	where TRequest : IRequest where TResponse : IResponse
{
	public PagedQuery(ODataQueryOptions<TRequest> queryOptions)
	{
		QueryOptions = queryOptions;
	}

	public ODataQueryOptions<TRequest> QueryOptions { get; }
}
