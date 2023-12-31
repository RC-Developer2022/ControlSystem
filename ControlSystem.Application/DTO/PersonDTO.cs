namespace ControlSystem.Application.DTO;

public class PersonDTO
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDay { get; set; }
    public string Identity { get; set; }
    public string IndividualRegistration { get; set; }
    public bool Working { get; set; } = false;

    public PersonDTO() { }

}
