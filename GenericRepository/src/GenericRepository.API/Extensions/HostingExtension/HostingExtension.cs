using GenericRepository.Domain.Customers.Repository;
using GenericRepository.Domain.Products.Repository;

namespace GenericRepository.API.Extensions.HostingExtension;

public static class HostingExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<ICustomerRepository>();
        services.AddTransient<IProductRepository>();

        return services;
    }
}
