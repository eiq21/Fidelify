using Fidelify.Application.Abstractions.Messaging;

namespace Fidelify.Application.Customers.GetCustomer;
public sealed record GetCustomerQuery(Guid Id) : IQuery<CustomerResponse>;