﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.PasswordHasher;
public interface IPasswordHasher
{
    string Hash(string password);
    bool Verify(string password, string hash);
}

