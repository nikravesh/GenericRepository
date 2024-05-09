using GenericRepository.Data.Base;
using GenericRepository.Data.DataContext;
using GenericRepository.Domain.Customers.Entities;
using GenericRepository.Domain.Customers.Repository;

namespace GenericRepository.Data.Customers.Repository;
public class CustomerRepository : BaseRepository<GenericRepositoryDbContext, Customer, long>, ICustomerRepository
{
    public CustomerRepository(GenericRepositoryDbContext dbContext) : base(dbContext)
    {
    }
}
