using Fidelify.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fidelify.Infrastructure.Configurations;
public sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customer");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.FirstName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(c => c.LastName)
        .HasMaxLength(50);

        builder.Property(c => c.Email)
         .HasMaxLength(125)
        .IsRequired();

        builder.Property(c => c.PhoneNumber)
        .HasMaxLength(25);

        builder.Property(c => c.LoyaltyPoints);

    }
}
