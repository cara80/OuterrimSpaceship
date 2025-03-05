using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Web_OuterrimSpaceship.DB;

namespace Model_OuterrimSpaceship.Repos;


public class ARepositoryAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
{
    private AircraftContext _context;
    private DbSet<TEntity> _table;

    public ARepositoryAsync(AircraftContext context)
    {
        _context = context;
        _table = context.Set<TEntity>();
    }
    
    public async Task<TEntity> CreateAsync(TEntity t)
    {
        await _table.AddAsync(t);
        await _context.SaveChangesAsync();
        return t;
    }

    public async Task<List<TEntity>> CreateRangeAsync(List<TEntity> list)
    {
        await _table.AddRangeAsync(list);
        await _context.SaveChangesAsync();
        return list;
    }

    public async Task UpdateAsync(TEntity t)
    {
        _context.ChangeTracker.Clear();
        _table.Update(t);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRangeAsync(List<TEntity> list)
    {
        _context.ChangeTracker.Clear();
        _table.UpdateRange(list);
        await _context.SaveChangesAsync();
    }
    
    public async Task<TEntity?> ReadAsync(int id) => 
        await _table.FindAsync(id);

    public async Task<List<TEntity>> ReadAsync(Expression<Func<TEntity, bool>> filter) => 
        await _table.Where(filter).ToListAsync();

    public async Task<List<TEntity>> ReadAsync(int start, int count) =>
        await _table.Skip(start).Take(count).ToListAsync();

    public async Task<List<TEntity>> ReadAllAsync() => await _table.ToListAsync();

    public async Task DeleteAsync(TEntity t)
    {
        _table.Remove(t);
        await _context.SaveChangesAsync();
    }
}