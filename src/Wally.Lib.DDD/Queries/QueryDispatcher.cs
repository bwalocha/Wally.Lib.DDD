using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Wally.Lib.DDD.Abstractions.Queries;
using Wally.Lib.DDD.Abstractions.Responses;

namespace Wally.Lib.DDD.Queries;

public class QueryDispatcher : IQueryDispatcher
{
	private readonly IServiceProvider _serviceProvider;

	public QueryDispatcher(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
	}

	public Task<TResult> HandleAsync<TQuery, TResult>(TQuery query, CancellationToken cancellationToken)
		where TQuery : IQuery<TResult> where TResult : IResponse
	{
		var service = _serviceProvider.GetRequiredService<IQueryHandler<TQuery, TResult>>();

		return service.HandleAsync(query, cancellationToken);
	}
}
