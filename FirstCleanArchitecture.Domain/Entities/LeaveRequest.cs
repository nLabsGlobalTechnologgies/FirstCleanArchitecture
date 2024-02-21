using FirstCleanArchitecture.Domain.Abstractions;
using FirstCleanArchitecture.Domain.Enums;

namespace FirstCleanArchitecture.Domain.Entities;
public sealed class LeaveRequest : Entity
{
    public string PhoneNumber { get; set; } = "LRF";
    public string RequestNumber { get; set; } = string.Empty;
    public LeaveType LeaveType { get; set; } = LeaveType.AnnualLeave;
    public string Reason { get; set; } = string.Empty;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public WorkFlow WorkFlow { get; set; } = WorkFlow.None;
    public Guid AssignedUserId { get; set; }
    public ADUser? AssignedUser { get; set; }
    public DateTime CreatedDate { get; private set; } = DateTime.Now;
    public Guid CreatedById { get; set; }
    public ADUser? CreatedBy { get; set; }
    public Guid LastModifiedById { get; set; }
    public ADUser? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}
