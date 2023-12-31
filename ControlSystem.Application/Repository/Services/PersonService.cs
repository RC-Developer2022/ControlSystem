using ControlSystem.Application.DTO;
using ControlSystem.Application.Mapper.Interfaces;
using ControlSystem.Application.Repository.Interfaces;
using ControlSystem.Infrastructure.Core.Interfaces;

namespace ControlSystem.Application.Repository.Services;

public class PersonService : IPersonService
{
    private readonly IPersonPersistence _personPersistence;
    private readonly IMapperPerson _mapper;
    public PersonService(
        IPersonPersistence personPersistence,
        IMapperPerson mapper
    )
    {
        _personPersistence = personPersistence;
        _mapper = mapper;
    }
    public async Task<IEnumerable<PersonDTO>> GetAllPerson()
    {
        try
        {
            var persons = await _personPersistence.GetAllPerson();

            return _mapper.MapperDTOs(persons);

        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<PersonDTO> GetById(string id)
    {
        try
        {
            var person = await _personPersistence.GetById(Guid.Parse(id));

            return _mapper.MapperDTO(person);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<PersonDTO> GetByName(string name)
    {
        try
        {
            var person = await _personPersistence.GetByName(name);

            return _mapper.MapperDTO(person);

        }
        catch (Exception)
        {

            throw;
        }
    }
}
