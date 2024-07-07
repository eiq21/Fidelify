using Fidelify.Domain.Abstractions;

namespace Fidelify.Domain.Customers;
public static class CustomerErrors
{
    public static Error NotFound = new("Customer.Found", "Customer not found.");
}
