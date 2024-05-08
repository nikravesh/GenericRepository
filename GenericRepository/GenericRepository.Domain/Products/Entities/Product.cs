using GenericRepository.Domain.Common;

namespace GenericRepository.Domain.Products.Entities;
public class Product : BaseEntity
{
    public string ProductName { get; private set; }

    public string ProductDescription { get; private set; }

    public decimal ProductPrice { get; private set; }

    private Product()
    {
    }

    public Product(string productName, string productDescription, decimal productPrice)
    {
        ProductName = productName;
        ProductDescription = productDescription;
        ProductPrice = productPrice;
    }

    public static Product Create(Product product)
       => new(product.ProductName, product.ProductDescription, product.ProductPrice);

    public Product Update(Product product)
    {
        ProductName = product.ProductName;
        ProductDescription = product.ProductDescription;
        ProductPrice = product.ProductPrice;

        return this;
    }
}
