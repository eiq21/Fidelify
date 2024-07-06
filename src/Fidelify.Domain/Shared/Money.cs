namespace Fidelify.Domain.Shared;
public record Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }

    public Money(decimal amount, string currency)
    {
        if (amount < 0)
        {
            throw new InvalidOperationException("Amount cannot be negative");
        }

        if (string.IsNullOrWhiteSpace(currency))
        {
            throw new InvalidOperationException("Currency cannot be empty");
        }

        Amount = amount;
        Currency = currency;
    }

    public static Money operator +(Money left, Money right)
    {
        if (left.Currency != right.Currency)
        {
            throw new InvalidOperationException("Cannot add money with different currencies");
        }

        return new Money(left.Amount + right.Amount, left.Currency);
    }

    public static Money operator -(Money left, Money right)
    {
        if (left.Currency != right.Currency)
        {
            throw new InvalidOperationException("Cannot subtract money with different currencies");
        }

        return new Money(left.Amount - right.Amount, left.Currency);
    }

    public override string ToString() => $"{Amount} {Currency}";
}
