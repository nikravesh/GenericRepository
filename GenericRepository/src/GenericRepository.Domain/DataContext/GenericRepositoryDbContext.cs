using GenericRepository.Data.Base;
using GenericRepository.Domain.Customer;
using GenericRepository.Domain.Products;

using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Data.DataContext;
public class GenericRepositoryDbContext : BaseDbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Customer> Customers { get; set; }
}
