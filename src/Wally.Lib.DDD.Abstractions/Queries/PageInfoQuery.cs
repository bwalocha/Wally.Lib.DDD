namespace Wally.Lib.DDD.Abstractions.Queries
{
	public class PageInfoQuery
	{
		public PageInfoQuery(int index = 0, int size = int.MaxValue)
		{
			Index = index;
			Size = size;
		}

		public int Index { get; }

		public int Size { get; }
	}
}
