using FirstCleanArchitecture.Domain.Abstractions;

namespace FirstCleanArchitecture.Domain.Entities;
public sealed class Notification : Entity
{
    public Guid UserId { get; set; }
    public ADUser? User { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public Guid CumulativeLeaveRequestId { get; set; }
    public CumulativeLeaveRequest? CumulativeLeaveRequest { get; set; }
}
