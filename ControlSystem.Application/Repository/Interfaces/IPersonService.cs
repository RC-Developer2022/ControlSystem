using ControlSystem.Application.DTO;
using ControlSystem.Domain.Entities;

namespace ControlSystem.Application.Repository.Interfaces;

public interface IPersonService
{
    Task<IEnumerable<PersonDTO>> GetAllPerson();
    Task<PersonDTO> GetById(string id);
    Task<PersonDTO> GetByName(string name);
}
