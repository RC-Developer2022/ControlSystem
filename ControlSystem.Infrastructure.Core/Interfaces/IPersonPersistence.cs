using ControlSystem.Domain.Entities;

namespace ControlSystem.Infrastructure.Core.Interfaces;

public interface IPersonPersistence
{
    Task<IEnumerable<Person>> GetAllPerson();
    Task<Person> GetById(Guid id);
    Task<IEnumerable<Person>> GetByName(string name);
}
