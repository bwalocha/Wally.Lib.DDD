using Wally.Lib.DDD.Abstractions.Queries;

namespace Wally.Lib.DDD.Abstractions.Responses
{
	public class PageInfoResponse : IResponse
	{
		public PageInfoResponse(PageInfoQuery pageInfo, int totalItems)
		{
			Index = pageInfo.Index;
			Size = pageInfo.Size;
			TotalItems = totalItems;
		}

		public int Index { get; }

		public int Size { get; }

		public int TotalItems { get; }
	}
}
