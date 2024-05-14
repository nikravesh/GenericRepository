using System.Linq.Expressions;

using GenericRepository.Domain.Base;

using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Data.Base;
public abstract class BaseRepository<TDbContext, TEntity, TId> : IBaseRepository<TEntity, TId>
    where TDbContext : BaseDbContext
    where TEntity : class
    where TId : struct
{
    protected readonly TDbContext _dbContext;

    public BaseRepository(TDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void Insert(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
        SaveChanges();
    }

    public async Task InsertAsync(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
        await SaveChangesAsync();
    }

    public void Delete(TId id)
    {
        TEntity? entity = _dbContext.Set<TEntity>().Find(id);
        _dbContext.Set<TEntity>().Remove(entity);

        SaveChanges();
    }

    public async Task DeleteAsync(TId id)
    {
        TEntity? entity = await _dbContext.Set<TEntity>().FindAsync(id);

        if (entity is not null)
            _dbContext.Set<TEntity>().Remove(entity);

        await SaveChangesAsync();
    }

    public void Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
        SaveChanges();
    }

    public TEntity? GetById(TId id)
    {
        return _dbContext.Set<TEntity>().Find(id);
    }

    public virtual async Task<TEntity?> GetByIdAsync(TId id)
    {
        return await _dbContext.Set<TEntity>().FindAsync(id);
    }

    public async Task<IEnumerable<TEntity>> SelectAll()
    {
        return await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
    }

    public void Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        SaveChanges();
    }

    private async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    private void SaveChanges()
    {
        _dbContext.SaveChanges();
    }

    public bool Exists(Expression<Func<TEntity, bool>> expression)
    {
        return _dbContext.Set<TEntity>().Any(expression);
    }

    public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _dbContext.Set<TEntity>().AnyAsync(expression);
    }
}
