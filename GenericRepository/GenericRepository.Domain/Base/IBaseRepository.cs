using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Domain.Base;
public interface IBaseRepository<TEntity,TId>
{
    void Delete(TId id);
    void Delete(TEntity entity);
    Task DeleteAsync(TId id);
    TEntity? GetById(TId id);
    Task<TEntity?> GetByIdAsync(TId id);
    void Insert(TEntity entity);
    Task InsertAsync(TEntity entity);
    Task<IEnumerable<TEntity>> SelectAll();
    void Update(TEntity entity);
}
