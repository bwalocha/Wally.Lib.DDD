using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public abstract class PagedQuery<TResult> : IQuery<PagedResponse<TResult>> where TResult : IResponse
	{
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
