﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    Task<T?>        GetByIdAsync(Guid id);
    Task<List<T>>   GetAllAsync();
    Task<List<T>>   FindAsync(Expression<Func<T, bool>> predicate);
    Task            AddAsync(T entity);
    void            Remove(T entity);
    Task<bool>      ExistsAsync(Guid id);
    Task<T?>        Update(T entity);
}
