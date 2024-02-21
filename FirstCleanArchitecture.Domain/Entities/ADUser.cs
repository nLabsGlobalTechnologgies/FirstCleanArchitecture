using FirstCleanArchitecture.Domain.Abstractions;
using FirstCleanArchitecture.Domain.Enums;

namespace FirstCleanArchitecture.Domain.Entities;
public sealed class ADUser : Entity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public UserType UserType { get; set; } = UserType.BlueCollarEmployee;
    public Guid ManagerId { get; set; }
    public ADUser? Manager { get; set; }
}
