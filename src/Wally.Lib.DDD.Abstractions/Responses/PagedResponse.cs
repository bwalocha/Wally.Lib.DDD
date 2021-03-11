namespace Wally.Lib.DDD.Abstractions.Responses
{
	public sealed class PagedResponse<TResponse> : IResponse where TResponse : IResponse
	{
		public PagedResponse(TResponse[] items, PageInfoResponse pageInfo)
		{
			Items = items;
			PageInfo = pageInfo;
		}

		public TResponse[] Items { get; }

		public PageInfoResponse PageInfo { get; }
	}
}
