﻿using System;
using System.Collections.Generic;

namespace RoleBasedAccessManagement.Infrastructure.Models;

public partial class RolesUser
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}
