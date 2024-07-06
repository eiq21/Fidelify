using Fidelify.Domain.Abstractions;
using Fidelify.Domain.Shared;

namespace Fidelify.Domain.Customers;
public sealed class Transaction : Entity<Guid>
{
    private Transaction(
        Guid transactionId,
        Guid customerId,
        Money amount,
        DateTime transactionDateOnUtc) : base(transactionId)
    {
        CustomerId = customerId;
        Amount = amount;
        TransactionDateOnUtc = transactionDateOnUtc;
    }

    public Guid CustomerId { get; private set; }
    public Money Amount { get; private set; }
    public DateTime TransactionDateOnUtc { get; private set; }

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

    private Transaction() { }
}
