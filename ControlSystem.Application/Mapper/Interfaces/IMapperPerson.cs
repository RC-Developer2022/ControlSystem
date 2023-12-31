using ControlSystem.Application.DTO;
using ControlSystem.Domain.Entities;

namespace ControlSystem.Application.Mapper.Interfaces;

public interface IMapperPerson
{
    PersonDTO MapperDTO(Person person);

    Person MapperEntity(PersonDTO personDTO);

    IEnumerable<PersonDTO> MapperDTOs(IEnumerable<Person> persons);

    IEnumerable<Person> MapperEntities(IEnumerable<PersonDTO> personsDTO);

}
