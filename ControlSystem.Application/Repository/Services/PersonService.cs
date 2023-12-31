using ControlSystem.Application.DTO;
using ControlSystem.Application.Mapper.Interfaces;
using ControlSystem.Application.Repository.Interfaces;
using ControlSystem.Infrastructure.Core.Interfaces;
using ControlSystem.Infrastructure.Core.Interfaces.Base;

namespace ControlSystem.Application.Repository.Services;

public class PersonService : IPersonService
{
    private readonly IPersonPersistence _personPersistence;
    private readonly IGeneralPersistence _generalPersistence;
    private readonly IMapperPerson _mapper;
    public PersonService(
        IPersonPersistence personPersistence,
        IGeneralPersistence generalPersistence,
        IMapperPerson mapper
    )
    {
        _personPersistence = personPersistence;
        _generalPersistence = generalPersistence;
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

    public async Task AddPerson(PersonDTO personDTO)
    {
        try
        {
            await _generalPersistence.AddAsync(_mapper.MapperEntity(personDTO));
        }
        catch (Exception)
        {

            throw;
        }
    }

    public Task DeletePerson(string id)
    {
        try
        {

        }
        catch (Exception)
        {

            throw;
        }
    }
    public Task Update(PersonDTO personDTO)
    {
        try
        {

        }
        catch (Exception)
        {

            throw;
        }
    }
}
