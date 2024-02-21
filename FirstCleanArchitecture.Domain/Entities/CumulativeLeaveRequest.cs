using FirstCleanArchitecture.Domain.Abstractions;
using FirstCleanArchitecture.Domain.Enums;

namespace FirstCleanArchitecture.Domain.Entities;
public sealed class CumulativeLeaveRequest : Entity
{
    public LeaveType LeaveType { get; set; } = LeaveType.AnnualLeave;
    public Guid UserId { get; set; }
    public ADUser? User { get; set; }
    public int TotalHours { get; set; } = 0;
    public int Year { get; set; } = 0;
}
