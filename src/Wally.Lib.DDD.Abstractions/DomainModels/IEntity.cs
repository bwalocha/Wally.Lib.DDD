namespace Wally.Lib.DDD.Abstractions.DomainModels;

public interface IEntity<out TKey>
{
	TKey Id { get; }
}
