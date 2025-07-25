﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;

public class Role
{
    public Guid         Id      { get; set; }
    public string       Name    { get; set; } = string.Empty;
    public List<User>   Users   { get; set; } = default!;
}
