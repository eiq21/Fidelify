using Fidelify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Fidelify.Infrastructure.Repositories;
public class Repository<TEntity>
where TEntity : Entity<Guid>
{
    private readonly ApplicationDbContext _dbContext;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TEntity?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _dbContext
        .Set<TEntity>()
        .FirstOrDefaultAsync(entry => entry.Id == id, cancellationToken);
    }

    public void Add(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }
        _dbContext.Add(entity);
    }
}
