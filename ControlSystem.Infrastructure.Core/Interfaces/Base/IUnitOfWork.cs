namespace ControlSystem.Infrastructure.Core.Interfaces.Base;

public interface IUnitOfWork
{
    Task<bool> Commit();
    Task Rollback();
}
