namespace Fidelify.Application.Customers.GetCustomer;
public sealed class CustomerResponse
{
    public Guid Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; }
    public int LoyaltyPoints { get; init; }
}
