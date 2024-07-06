using Fidelify.Domain.Abstractions;
using Fidelify.Domain.Customers;
using Fidelify.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fidelify.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        AddPersistence(services, configuration);
        return services;
    }

    public static void AddPersistence(IServiceCollection services, IConfiguration configuration)
    {
        var GetConnectionString =
        configuration.GetConnectionString("DefaultConnection") ??
        throw new ArgumentNullException(nameof(configuration));

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(GetConnectionString));

        services.AddScoped<ICustomerRepository, CustomerRepository>();

        services.AddScoped<IUnitOfWork>(sp =>
        sp.GetRequiredService<ApplicationDbContext>());
    }
}
