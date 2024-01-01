using ControlSystem.Domain;

namespace ControlSystem.Infrastructure.Core.Interfaces.Base;

public interface IGeneralPersistence<T> where T : Entity
{
    Task AddAsync(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}
