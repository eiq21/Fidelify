using Fidelify.Domain.Abstractions;
using Fidelify.Domain.Shared;

namespace Fidelify.Domain.Customers;
public sealed class Transaction : Entity<Guid>
{
    private Transaction(
        Guid transactionId,
        Guid customerId,
        Money amount,
        DateTime dateOnUtc) : base(transactionId)
    {
        CustomerId = customerId;
        Amount = amount;
        DateOnUtc = dateOnUtc;
    }

    public Guid CustomerId { get; private set; }
    public Money Amount { get; private set; }
    public DateTime DateOnUtc { get; private set; }

    public static Transaction Create(
        Guid customerId,
        Money amount,
        DateTime transactionDate)
    {
        return new Transaction(
            Guid.NewGuid(),
            customerId,
            amount,
            transactionDate);
    }
}
