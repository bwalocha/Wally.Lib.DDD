using FluentAssertions;
using Xunit;

namespace Wally.Lib.DDD.Tests
{
	public class UnitTest
	{
		[Fact]
		public void Test()
		{
			true.Should()
				.BeTrue();
		}
	}
}
