using System.Threading;
using System.Threading.Tasks;

namespace Wally.Lib.DDD.Abstractions.Managers
{
	public interface IPersistenceManager
	{
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
