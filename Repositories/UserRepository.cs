using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Repositories.Base;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(AppDbContext db) : base(db) { }

    public async Task<User?> GetByEmailAsync(string email)
        => await _set.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == email);

    public async Task<User?> GetByRefreshTokenAsync(string token)
        => await _set.Include(u => u.Role)
                     .FirstOrDefaultAsync(u => u.RefreshToken == token && u.RefreshTokenExpires > DateTime.UtcNow);
    public async Task<bool> ExistsByEmailAsync(string email)
        => await _set.AnyAsync(u => u.Email == email);
}
