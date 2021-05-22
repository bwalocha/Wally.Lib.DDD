using Newtonsoft.Json;
using Wally.Lib.DDD.Abstractions.Queries;

namespace Wally.Lib.DDD.Abstractions.Responses
{
	public class PageInfoResponse : IResponse
	{
		[JsonConstructor]
		public PageInfoResponse(int index, int size, int totalItems)
			: this(new PageInfoQuery(index, size), totalItems)
		{
		}

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
