using System;
using System.Collections.Generic;

namespace RoleBasedAccessManagement.Infrastructure.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string BirthDate { get; set; } = null!;

    public string ContactNo { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Type { get; set; } = null!;

    public virtual ICollection<RolesUser> RolesUsers { get; set; } = new List<RolesUser>();
}
