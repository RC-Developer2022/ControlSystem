namespace ControlSystem.Domain.Entities;

public class Person : Entity
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDay { get; set; }
    public string Identity { get; set; }
    public string IndividualRegistration { get; set; }
    public bool Working { get; set; } = false;

    public Person() {}

    public Person(string name, int age, DateTime birthDay, string identity, string individualRegistration, bool working)
    {
        Name = name;
        Age = age;
        BirthDay = birthDay;
        Identity = identity;
        IndividualRegistration = individualRegistration;
        Working = working;
    }
}
