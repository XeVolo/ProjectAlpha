using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces;

public interface IUnitOfWork
{
    IUserRepository     Users { get; }
    IRepository<Role>   Roles { get; }
    Task                SaveChangesAsync();
}

