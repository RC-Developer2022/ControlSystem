using ControlSystem.Application.Core.DTO;
using ControlSystem.Application.Core.Mapper.Interfaces;
using ControlSystem.Application.Repository.Interfaces;
using ControlSystem.Domain.Entities;
using ControlSystem.Infrastructure.Core.Interfaces;
using ControlSystem.Infrastructure.Core.Interfaces.Base;

namespace ControlSystem.Application.Repository.Services;

public class PersonService : IPersonService

{
    private readonly IPersonPersistence _personPersistence;
    private readonly IGeneralPersistence<Person> _generalPersistence;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapperPerson _mapper;
    public PersonService(
        IPersonPersistence personPersistence,
        IGeneralPersistence<Person> generalPersistence,
        IUnitOfWork unitOfWork,
        IMapperPerson mapper
    )
    {
        _personPersistence = personPersistence;
        _generalPersistence = generalPersistence;
        _unitOfWork = unitOfWork;
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
            await _unitOfWork.Rollback();
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
            await _unitOfWork.Rollback();
            throw;
        }
    }

    public async Task<IEnumerable<PersonDTO>> GetByName(string name)
    {
        try
        {
            var persons = await _personPersistence.GetByName(name);

            return _mapper.MapperDTOs(persons);

        }
        catch (Exception)
        {

            await _unitOfWork.Rollback();
            throw;
        }
    }

    public async Task AddPerson(PersonDTO personDTO)
    {
        try
        {
            if (personDTO.Id == null)
            {
                personDTO.Id = Guid.NewGuid().ToString();
                var person = _mapper.MapperEntity(personDTO);
                await _generalPersistence.AddAsync(person);
                await _unitOfWork.Commit();
            }
        }
        catch (Exception)
        {
            await _unitOfWork.Rollback();
        }
    }

    public async Task DeletePerson(string id)
    {
        try
        {
            var person = await _personPersistence.GetById(Guid.Parse(id));
            await _generalPersistence.Delete(person);
            await _unitOfWork.Commit();
        }
        catch (Exception)
        {

            await _unitOfWork.Rollback();
        }
    }
    public async Task UpdatePerson(PersonDTO personDTO)
    {
        try
        {
            await _generalPersistence.Update(_mapper.MapperEntity(personDTO));
            await _unitOfWork.Commit();
        }
        catch (Exception)
        {

            await _unitOfWork.Rollback();
        }
    }
}
