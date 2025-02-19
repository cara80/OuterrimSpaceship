using System.Linq.Expressions;

namespace Model_OuterrimSpaceship.Repos;

public interface IRepositoryAsync<TEntity> where TEntity : class
{
    Task<TEntity> CreateAsync(TEntity t);

    Task<List<TEntity>> CreateRangeAsync(List<TEntity> list);

    Task UpdateAsync(TEntity t);

    Task UpdateRangeAsync(List<TEntity> list);

    Task<TEntity?> ReadAsync(int id);

    Task<List<TEntity>> ReadAsync(Expression<Func<TEntity, bool>> filter);

    Task<List<TEntity>> ReadAsync(int start, int count);

    Task<List<TEntity>> ReadAllAsync();

    Task DeleteAsync(TEntity t);
}