namespace Fidelify.Domain.Abstractions;
public abstract class Entity<TEntityId>
{
    private readonly List<IDomainEvent> _domainEvents = new();

    public TEntityId Id { get; init; }

    protected Entity(TEntityId id)
    {
        Id = id;
    }
    protected Entity()
    {
    }

    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void RemoveDomainEvent()
    {
        _domainEvents.Clear();
    }
}
