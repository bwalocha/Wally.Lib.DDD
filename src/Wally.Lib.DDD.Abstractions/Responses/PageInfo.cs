namespace Wally.Lib.DDD.Abstractions.Responses
{
	public class PageInfo : IResponse
	{
		public PageInfo(int totalItems, int index = 0, int size = 0)
		{
			Index = index;
			Size = size == 0 ? totalItems : size;
			TotalItems = totalItems;
		}

		public int Index { get; }

		public int Size { get; }

		public int TotalItems { get; }
	}
}
