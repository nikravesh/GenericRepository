using GenericRepository.Domain.Products.Repository;

using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.API.Controllers.Products;
public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpPost("{id}")]
    public async Task<IActionResult> GetProduct(long productId)
       => Ok(await _productRepository.GetByIdAsync(productId));
}
