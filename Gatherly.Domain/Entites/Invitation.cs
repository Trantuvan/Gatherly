using Gatherly.Domain.Enums;
using Gatherly.Domain.Primitives;

namespace Gatherly.Domain.Entites;

public class Invitation : Entity
{
    internal Invitation(Guid id, Member member, Gathering gathering) : base(id)
    {
        MemberId = member.Id;
        GatheringId = gathering.Id;
        Status = InvitationStatus.Pending;
        CreateOnUtc = DateTime.UtcNow;
    }

    public Guid MemberId { get; private set; }
    public Guid GatheringId { get; private set; }
    public InvitationStatus Status { get; private set; }
    public DateTime CreateOnUtc { get; private set; }
}