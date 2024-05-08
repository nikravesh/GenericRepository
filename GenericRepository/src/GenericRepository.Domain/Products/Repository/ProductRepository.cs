using GenericRepository.Data.Base;
using GenericRepository.Data.DataContext;
using GenericRepository.Domain.Products.Entities;
using GenericRepository.Domain.Products.Repository;

namespace GenericRepository.Data.Products.Repository;
public class ProductRepository : BaseRepository<GenericRepositoryDbContext, Product, long>, IProductRepository
{
    public ProductRepository(GenericRepositoryDbContext dbContext) : base(dbContext)
    {
    }
}
