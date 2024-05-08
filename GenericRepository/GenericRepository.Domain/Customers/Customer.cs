using GenericRepository.Domain.Common;

namespace GenericRepository.Domain.Customer;
public class Customer : BaseEntity
{
    public string CustomerFiratName { get; private set; }

    public string CustomerLastName { get; private set; }

    public string CustomerEmail { get; private set; }

    private Customer()
    {
    }

    public Customer(string customerFirstName, string customerLastName, string customerEmail)
    {
        CustomerFiratName = customerFirstName;
        CustomerLastName = customerLastName;
        CustomerEmail = customerEmail;
    }

    public static Customer Create(Customer customer)
        => new(customer.CustomerFiratName, customer.CustomerLastName, customer.CustomerEmail);

    public Customer Update(Customer customer)
    {
        CustomerFiratName = customer.CustomerFiratName;
        CustomerLastName = customer.CustomerLastName;
        CustomerEmail = customer.CustomerEmail;

        return this;
    }
}
