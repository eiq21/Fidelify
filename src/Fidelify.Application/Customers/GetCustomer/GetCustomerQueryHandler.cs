using Fidelify.Application.Abstractions.Messaging;
using Fidelify.Domain.Abstractions;
using Fidelify.Domain.Customers;

namespace Fidelify.Application.Customers.GetCustomer;
internal sealed class GetCustomerQueryHandler : IQueryHandler<GetCustomerQuery, CustomerResponse>
{
    private readonly ICustomerRepository _customerRepository;
    public GetCustomerQueryHandler(
        ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    public async Task<Result<CustomerResponse>> Handle(
        GetCustomerQuery request,
        CancellationToken cancellationToken)
    {
        var customerResult = await _customerRepository
        .GetByIdAsync(
            request.Id,
            cancellationToken);

        if (customerResult is null)
        {
            return Result.Failure<CustomerResponse>(CustomerErrors.NotFound);
        }

        return new CustomerResponse
        {
            Id = customerResult.Id,
            FirstName = customerResult.FirstName,
            LastName = customerResult.LastName,
            Email = customerResult.Email,
            PhoneNumber = customerResult.PhoneNumber,
            LoyaltyPoints = customerResult.LoyaltyPoints
        };

    }
}
