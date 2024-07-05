namespace Fidelify.Domain.Customers;
public sealed class Customer
{
    public Guid CustomerId { get; private set; }
    public string FistName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
}
