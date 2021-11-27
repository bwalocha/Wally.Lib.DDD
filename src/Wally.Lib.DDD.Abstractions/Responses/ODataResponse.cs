using System.Linq;

namespace Wally.Lib.DDD.Abstractions.Responses
{
	public sealed class ODataResponse<TResponse> : IResponse where TResponse : IResponse
	{
		public IQueryable<TResponse> Response { get; }

		public ODataResponse(IQueryable<TResponse> response)
		{
			Response = response;
		}
	}
}
