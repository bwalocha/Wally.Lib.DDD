using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Wally.Lib.DDD.Abstractions.DomainModels;

namespace Wally.Lib.DDD.Abstractions.Managers
{
	public interface IPersistenceManager
	{
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);

		IEnumerable<Entity> GetEntities();
	}
}
