﻿using System;
using System.Collections.Generic;

namespace RoleBasedAccessManagement.Infrastructure.Models;

public partial class RolesMenu
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public int? MenuId { get; set; }

    public virtual Menu? Menu { get; set; }

    public virtual Role? Role { get; set; }
}
