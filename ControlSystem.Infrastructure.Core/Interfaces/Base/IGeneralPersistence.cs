namespace ControlSystem.Infrastructure.Core.Interfaces.Base;

public interface IGeneralPersistence
{
    Task AddAsync<T>(T entity);
    Task Update<T>(T entity);
    Task Delete<T>(T entity);
}
