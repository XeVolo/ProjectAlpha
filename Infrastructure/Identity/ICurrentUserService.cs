﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity;
public interface ICurrentUserService
{
    Guid? UserId { get; }
    Guid? AdminId { get; }
}
