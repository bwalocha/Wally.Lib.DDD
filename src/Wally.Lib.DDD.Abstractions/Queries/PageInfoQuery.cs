namespace Wally.Lib.DDD.Abstractions.Queries
{
	public class PageInfoQuery
	{
		public PageInfoQuery(int index = 0, int size = 0)
		{
			Index = index;
			Size = size == 0 ? 10 : size;
		}

		public int Index { get; }

		public int Size { get; }
	}
}
