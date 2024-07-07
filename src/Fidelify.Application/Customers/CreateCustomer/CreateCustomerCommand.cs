using System.Windows.Input;
using Fidelify.Application.Abstractions.Messaging;
using MediatR;

namespace Fidelify.Application.Customers.CreateCustomer;
public sealed record CreateCustomerCommand(
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber) : ICommand<Guid>;
