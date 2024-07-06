using Fidelify.Domain.Customers;

namespace Fidelify.Infrastructure.Repositories;
public sealed class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext dbContext)
    : base(dbContext)
    {
    }
}
