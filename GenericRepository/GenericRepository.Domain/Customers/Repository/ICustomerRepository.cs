using GenericRepository.Domain.Base;
using GenericRepository.Domain.Customers.Entities;

namespace GenericRepository.Domain.Customers.Repository;
public interface ICustomerRepository : IBaseRepository<Customer,long>
{
}
