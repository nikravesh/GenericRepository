using GenericRepository.Domain.Base;
using GenericRepository.Domain.Products.Entities;

namespace GenericRepository.Domain.Products.Repository;
public interface IProductRepository : IBaseRepository<Product,long>
{
}
