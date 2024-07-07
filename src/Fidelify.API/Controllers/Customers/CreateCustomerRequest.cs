namespace Fidelify.API.Controllers.Customers;
public sealed record CreateCustomerRequest(
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber);
