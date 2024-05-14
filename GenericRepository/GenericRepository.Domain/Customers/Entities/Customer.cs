using GenericRepository.Domain.Common;

namespace GenericRepository.Domain.Customers.Entities;
public class Customer : BaseEntity
{
    public string CustomerFirstName { get; private set; }

    public string CustomerLastName { get; private set; }

    public string CustomerEmail { get; private set; }

    private Customer()
    {
    }

    private Customer(string customerFirstName, string customerLastName, string customerEmail)
    {
        CustomerFirstName = customerFirstName;
        CustomerLastName = customerLastName;
        CustomerEmail = customerEmail;
    }

    public static Customer Create(Customer customer)
        => new(customer.CustomerFirstName, customer.CustomerLastName, customer.CustomerEmail);

    public Customer Update(Customer customer)
    {
        CustomerFirstName = customer.CustomerFirstName;
        CustomerLastName = customer.CustomerLastName;
        CustomerEmail = customer.CustomerEmail;

        return this;
    }
}
