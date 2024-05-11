using System.Text.Json;
using System.Text.Json.Serialization;

using GenericRepository.Domain.Customers.Entities;
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomer(long id)
        => Ok(await _customerRepository.GetByIdAsync(id));

    [HttpPost]
    public async Task<IActionResult> CreateCustomer(Customer customer)
    {
        try
        {
            await _customerRepository.InsertAsync(customer);

            return Ok(customer);
        }
        catch (Exception e)
        {
            //Take log
            return BadRequest(e.Message);
        }
    }
}
