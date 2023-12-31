using ControlSystem.Domain.Entities;
using ControlSystem.Infrastructure.Context;
using ControlSystem.Infrastructure.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControlSystem.Infrastructure.Services;

public sealed class PersonPersistence : IPersonPersistence
{
    private readonly SystemContext _context;
    private readonly DbSet<Person> _dbSet;
    public PersonPersistence(SystemContext context)
    {

        _context = context;
        _dbSet = _context.Set<Person>();
    }
    public async Task<IEnumerable<Person>> GetAllPerson()
    {
        return await _dbSet.ToListAsync();
        
    }

    public async Task<Person> GetById(Guid id)
    {
        return await _dbSet
                    .Where(x => x.Id.Equals(id))
                    .FirstOrDefaultAsync();
    }

    public async Task<Person> GetByName(string name)
    {
        return await _dbSet
                    .Where(x => x.Name.Equals(name))
                    .FirstOrDefaultAsync();
    }
}
