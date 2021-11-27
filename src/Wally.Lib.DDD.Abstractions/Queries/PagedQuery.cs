using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public abstract class PagedQuery<TResponse> : IQuery<PagedResponse<TResponse>> where TResponse : IResponse
	{
		public PagedQuery() : this(new PageInfoQuery())
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
}
