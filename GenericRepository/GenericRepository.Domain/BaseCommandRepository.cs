﻿using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Data;
public class BaseCommandRepository<TDbContext, TEntity, TId>
    where TDbContext : BaseCommandContext
    where TEntity : class    
    where TId : struct
{
    protected readonly TDbContext _dbContext;

    public BaseCommandRepository(TDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void Insert(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
    }

    public async Task InsertAsync(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
    }

    public void Delete(TId id)
    {
        TEntity entity = _dbContext.Set<TEntity>().Find(id);
        _dbContext.Set<TEntity>().Remove(entity);
    }

    public async Task DeleteAsync(TId id)
    {
        TEntity entity = await _dbContext.Set<TEntity>().FindAsync(id);
        _dbContext.Set<TEntity>().Remove(entity);
    }

    public void Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
    }    

    public TEntity Select(TId id)
    {
        return _dbContext.Set<TEntity>().Find(id);
    }

    public async Task<TEntity> SelectAsync(TId id)
    {
        return await _dbContext.Set<TEntity>().FindAsync(id);
    }

    public IEnumerable<TEntity> SelectAll()
    {
        return _dbContext.Set<TEntity>().AsNoTracking();
    }

    public void Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
    }
}
