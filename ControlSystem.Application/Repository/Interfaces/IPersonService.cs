using ControlSystem.Application.Core.DTO;

namespace ControlSystem.Application.Repository.Interfaces;

public interface IPersonService
{
    Task<IEnumerable<PersonDTO>> GetAllPerson();
    Task<PersonDTO> GetById(string id);
    Task<IEnumerable<PersonDTO>> GetByName(string name);

    Task AddPerson(PersonDTO personDTO);
    Task DeletePerson(string id);
    Task UpdatePerson(PersonDTO personDTO);
}
