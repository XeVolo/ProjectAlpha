using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Base;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext _db;
    protected readonly DbSet<T> _set;

    public Repository(AppDbContext db)
    {
        _db = db;
        _set = _db.Set<T>();
    }

    public virtual async Task<T?> GetByIdAsync(Guid id)
        => await _set.FindAsync(id);

    public virtual async Task<List<T>> GetAllAsync()
        => await _set.ToListAsync();

    public virtual async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate)
        => await _set.Where(predicate).ToListAsync();

    public virtual async Task AddAsync(T entity)
        => await _set.AddAsync(entity);

    public virtual void Remove(T entity)
        => _set.Remove(entity);

    public virtual async Task<bool> ExistsAsync(Guid id)
        => await _set.AnyAsync(e => EF.Property<Guid>(e, "Id") == id);
}
