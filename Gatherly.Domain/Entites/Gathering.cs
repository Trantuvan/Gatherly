using Gatherly.Domain.Enums;
using Gatherly.Domain.Primitives;

namespace Gatherly.Domain.Entites;

public sealed class Gathering : Entity
{
    private readonly List<Invitation> _invitations = new();
    private readonly List<Attendee> _attendees = new();
    private Gathering(
        Guid id,
        Member creator,
        GatheringType type,
        DateTime scheduledAtUtc,
        string name,
        string? location) : base(id)
    {
        Creator = creator;
        Type = type;
        ScheduledAtUtc = scheduledAtUtc;
        Name = name;
        Location = location;
    }

    public Member Creator { get; private set; }
    public GatheringType Type { get; private set; }
    public DateTime ScheduledAtUtc { get; private set; }
    public string Name { get; private set; }
    public string? Location { get; private set; }
    public IReadOnlyCollection<Invitation> Invitations => _invitations;
    public IReadOnlyCollection<Attendee> Attendees => _attendees;
}
