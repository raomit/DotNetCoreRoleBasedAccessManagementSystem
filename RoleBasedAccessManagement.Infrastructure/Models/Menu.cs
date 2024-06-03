using System;
using System.Collections.Generic;

namespace RoleBasedAccessManagement.Infrastructure.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string MenuType { get; set; } = null!;

    public string? MenuNavigationLink { get; set; }

    public virtual ICollection<RolesMenu> RolesMenus { get; set; } = new List<RolesMenu>();
}
