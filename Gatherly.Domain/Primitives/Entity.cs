namespace Gatherly.Domain.Primitives;

public abstract class Entity : IEquatable<Entity>
{
    protected Entity(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; private init; }

    // overrided == operator
    public static bool operator ==(Entity? left, Entity? right)
    {
        return left is not null && right is not null && left.Equals(right);
    }

    public static bool operator !=(Entity? left, Entity? right)
    {
        return !(left == right);
    }

    // impl IEquatable
    public bool Equals(Entity? other)
    {
        if (other is null)
            return false;

        if (other.GetType() != GetType())
            return false;

        return other.Id == Id;
    }

    // override obj equal method
    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;

        // check the type of obj passed in not equal to the type of the curr object
        if (obj.GetType() != GetType())
            return false;

        // check the type of obj passed in is not inherit Entity abstract type
        if (obj is not Entity entity)
            return false;

        // an Entity is equal if has the same Id
        return entity.Id == Id;
    }

    public override int GetHashCode()
    {
        // multiple by prime num
        return Id.GetHashCode() * 41;
    }
}
