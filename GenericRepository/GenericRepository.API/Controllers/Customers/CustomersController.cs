using GenericRepository.Domain.Customers.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.API.Controllers.Customers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerRepository _customerRepository;

    public CustomersController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [HttpPost("{id}")]
    public async Task<IActionResult> GetCustomer(long customerId)
        => Ok(await _customerRepository.GetByIdAsync(customerId));
}
