using GenericRepository.Data.Base;
using GenericRepository.Data.DataContext;
using GenericRepository.Domain.Products;

namespace GenericRepository.Data.Products.Repository;
public class ProductRepository : BaseRepository<GenericRepositoryDbContext, Product, long>
{
    public ProductRepository(GenericRepositoryDbContext dbContext) : base(dbContext)
    {
    }
}
