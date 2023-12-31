using ControlSystem.Application.DTO;
using ControlSystem.Application.Mapper.Interfaces;
using ControlSystem.Domain.Entities;
using System;

namespace ControlSystem.Application.Mapper.Services;

public class MapperPerson : IMapperPerson
{
    public PersonDTO MapperDTO(Person person)
    {
        return new PersonDTO
        {
            Id = person.Id.ToString(),
            Name = person.Name,
            Age = person.Age,   
            BirthDay = person.BirthDay,
            Identity = person.Identity,
            IndividualRegistration = person.IndividualRegistration,
            Working = person.Working,
        };
    }

    public Person MapperEntity(PersonDTO personDTO)
    {
        return new Person
        {
            Id = Guid.Parse(personDTO.Id),
            Name = personDTO.Name,
            Age = personDTO.Age,
            BirthDay = personDTO.BirthDay,
            Identity = personDTO.Identity,
            IndividualRegistration = personDTO.IndividualRegistration,
            Working = personDTO.Working,
        };
    }

    public IEnumerable<PersonDTO> MapperDTOs(IEnumerable<Person> persons)
    {
        return persons.Select(person => new PersonDTO()
        {
            Id = person.Id.ToString(),
            Name = person.Name,
            Age = person.Age,
            BirthDay = person.BirthDay,
            Identity = person.Identity,
            IndividualRegistration = person.IndividualRegistration,
            Working = person.Working,
        });
    }

    public IEnumerable<Person> MapperEntities(IEnumerable<PersonDTO> personsDTO)
    {
        return personsDTO.Select(personDTO => new Person()
        {
            Id = Guid.Parse(personDTO.Id),
            Name = personDTO.Name,
            Age = personDTO.Age,
            BirthDay = personDTO.BirthDay,
            Identity = personDTO.Identity,
            IndividualRegistration = personDTO.IndividualRegistration,
            Working = personDTO.Working,
        });
    }
}
