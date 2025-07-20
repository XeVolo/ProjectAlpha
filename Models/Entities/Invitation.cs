using Models.Enums;

namespace Models.Entities;
public class Invitation
{
    public Guid             Id          { get; set; }
    public Guid             UserId      { get; set; }
    public User             User        { get; set; } = default!;
    public Guid             ProjectId   { get; set; }
    public Project          Project     { get; set; } = default!;
    public InvitationStatus Status      { get; set; }
    public bool             IsDeleted   { get; set; } = false;

}
