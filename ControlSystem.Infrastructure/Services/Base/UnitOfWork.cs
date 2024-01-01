using ControlSystem.Infrastructure.Context;
using ControlSystem.Infrastructure.Core.Interfaces.Base;

namespace ControlSystem.Infrastructure.Services.Base;

public class UnitOfWork : IUnitOfWork
{
    private readonly SystemContext _context;
    public UnitOfWork(SystemContext context)
    {
        _context = context;
    }
    public async Task<bool> Commit()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public Task Rollback()
    {
        return Task.CompletedTask;
    }
}
