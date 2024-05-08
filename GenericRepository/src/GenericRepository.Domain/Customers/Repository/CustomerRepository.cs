using GenericRepository.Data.Base;
using GenericRepository.Data.DataContext;
using GenericRepository.Domain.Customer;

namespace GenericRepository.Data.Customers.Repository;
public class CustomerRepository : BaseRepository<GenericRepositoryDbContext, Customer, long>
{
    public CustomerRepository(GenericRepositoryDbContext dbContext) : base(dbContext)
    {
    }
}
