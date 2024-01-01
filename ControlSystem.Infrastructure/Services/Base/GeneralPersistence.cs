using ControlSystem.Domain;
using ControlSystem.Infrastructure.Context;
using ControlSystem.Infrastructure.Core.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace ControlSystem.Infrastructure.Services.Base;

public class GeneralPersistence<T> : IGeneralPersistence<T> where T : Entity
{
    private readonly SystemContext _context;
    private readonly DbSet<T> _dbSet;
    public GeneralPersistence(SystemContext context)
    {
        _dbSet = context.Set<T>();
        _context = context;
    }
    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public async Task Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task Update(T entity)
    {
        _dbSet.Update(entity);
    }
}
