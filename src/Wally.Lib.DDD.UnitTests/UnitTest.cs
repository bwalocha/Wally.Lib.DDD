using FluentAssertions;

using Xunit;

namespace Wally.Lib.DDD.UnitTests;

public class UnitTest
{
	[Fact]
	public void Test()
	{
		true.Should()
			.BeTrue();
	}
}
