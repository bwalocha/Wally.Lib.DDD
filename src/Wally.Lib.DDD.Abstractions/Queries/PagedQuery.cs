﻿using Microsoft.AspNetCore.OData.Query;
using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public abstract class PagedQuery<TResult, TOResponse> : IQuery<PagedResponse<TResult>> 
		where TResult : IResponse
		where TOResponse : IResponse
	{
		public ODataQueryOptions<TOResponse> QueryOptions { get; }

		public PagedQuery(ODataQueryOptions<TOResponse> queryOptions)
		{
			QueryOptions = queryOptions;
		}
	}
	
	public abstract class PagedQuery<TResult> : IQuery<PagedResponse<TResult>> 
		where TResult : IResponse
	{
		public ODataQueryOptions<TResult> QueryOptions { get; }

		public PagedQuery(ODataQueryOptions<TResult> queryOptions)
		{
			QueryOptions = queryOptions;
		}
	}
}
