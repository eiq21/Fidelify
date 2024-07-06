using Fidelify.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fidelify.Infrastructure.Configurations;
public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transaction");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.CustomerId)
            .HasColumnName("CustomerId")
            .IsRequired();

        builder.Property(t => t.TransactionDateOnUtc)
            .HasColumnName("TransactionDateOnUtc")
            .IsRequired();

        builder.OwnsOne(transaction => transaction.Amount, amountBuilder =>
        {
            amountBuilder.Property(a => a.Amount)
                .HasColumnName("Amount")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            amountBuilder.Property(a => a.Currency)
                .HasColumnName("Currency")
                .HasMaxLength(3)
                .IsRequired();
        });

    }
}
