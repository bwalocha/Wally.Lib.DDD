using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Abstractions.Queries
{
	public interface IQuery<out TResponse> : MediatR.IRequest<TResponse> where TResponse : IResponse
	{
	}
}
