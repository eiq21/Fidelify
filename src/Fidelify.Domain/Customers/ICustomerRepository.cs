namespace Fidelify.Domain.Customers;
public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(Guid customerId, CancellationToken cancellationToken);
    void Add(Customer customer);
}
