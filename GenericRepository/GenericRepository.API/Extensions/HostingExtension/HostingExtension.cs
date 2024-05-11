using GenericRepository.Data.Customers.Repository;
using GenericRepository.Data.DataContext;
using GenericRepository.Data.Products.Repository;
using GenericRepository.Domain.Customers.Repository;
using GenericRepository.Domain.Products.Repository;

using Microsoft.EntityFrameworkCore;

namespace GenericRepository.API.Extensions.HostingExtension;

public static class HostingExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddDbContext<GenericRepositoryDbContext>(options => options.UseSqlServer(
        "Server=.;Initial Catalog=GenericRepoDb;User Id=sa;Password=241065@lireza;TrustServerCertificate=True", 
        x => x.MigrationsAssembly("GenericRepository.Data")));


        return services;
    }
}
