using ControlSystem.Infrastructure.Core.Interfaces.Base;

namespace ControlSystem.Infrastructure.Services.Base;

public class GeneralPersistence(IGeneralPersistence _generalPersistence) : IGeneralPersistence
{
    public async Task AddAsync<T>(T entity)
    {
        await _generalPersistence.AddAsync(entity);
    }

    public Task Delete<T>(T entity)
    {
        return _generalPersistence.Delete(entity);
    }

    public Task Update<T>(T entity)
    {
        return _generalPersistence.Update(entity);
    }
}
