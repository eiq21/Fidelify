using Fidelify.Domain.Abstractions;

namespace Fidelify.Domain.Customers;
public sealed class Customer : Entity<Guid>
{
    private Customer(
         Guid customerId,
         string firstName,
         string lastName,
         string email,
         string phoneNumber) : base(customerId)
    {
        FistName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }
    public string FistName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public int LoyaltyPoints { get; private set; }

    public List<Transaction> Transactions { get; private set; } = new();

    public static Customer Create(
        string firstName,
        string lastName,
        string email,
        string phoneNumber)
    {
        return new Customer(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            phoneNumber);
    }

    public void AddTransaction(Transaction transaction)
    {
        if (transaction == null)
        {
            throw new ArgumentNullException(nameof(transaction));
        }

        if (transaction.CustomerId != Id)
        {
            throw new InvalidOperationException("Transaction does not belong to this customer");
        }

        Transactions.Add(transaction);
        UpdateLoyaltyPoints(transaction);
    }

    private void UpdateLoyaltyPoints(Transaction transaction)
    {
        if (transaction.Amount.Amount > 0)
        {
            var pointsEarned = (int)(transaction.Amount.Amount * 0.1m);
            LoyaltyPoints += pointsEarned;
        }
    }

}
