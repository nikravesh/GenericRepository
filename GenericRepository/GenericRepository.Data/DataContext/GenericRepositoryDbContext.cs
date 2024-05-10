using GenericRepository.Data.Base;
using GenericRepository.Domain.Customers.Entities;
using GenericRepository.Domain.Products.Entities;

using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Data.DataContext;
public class GenericRepositoryDbContext : BaseDbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Customer> Customers { get; set; }


    public GenericRepositoryDbContext(DbContextOptions<GenericRepositoryDbContext> options)
        : base(options)
    {

    }
}