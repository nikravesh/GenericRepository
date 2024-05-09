using GenericRepository.Domain.Customers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GenericRepository.Data.Customers.Config;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable(nameof(Customer));
        builder.Property(c=>c.CustomerFirstName).HasMaxLength(50);
        builder.Property(c=>c.CustomerLastName).HasMaxLength(50);
        builder.Property(c=>c.CustomerEmail).HasMaxLength(100);
    }
}
