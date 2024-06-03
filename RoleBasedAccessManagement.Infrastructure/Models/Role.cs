using System;
using System.Collections.Generic;

namespace RoleBasedAccessManagement.Infrastructure.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleType { get; set; } = null!;

    public virtual ICollection<RolesMenu> RolesMenus { get; set; } = new List<RolesMenu>();

    public virtual ICollection<RolesUser> RolesUsers { get; set; } = new List<RolesUser>();
}
