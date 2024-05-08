using GenericRepository.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GenericRepository.Data.Products.Config;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(nameof(Product));
        builder.Property(p => p.ProductName).HasMaxLength(50);
        builder.Property(p => p.ProductDescription).HasMaxLength(250);
        builder.Property(p => p.ProductPrice).HasColumnType("decimal(22,2)");
    }
}
