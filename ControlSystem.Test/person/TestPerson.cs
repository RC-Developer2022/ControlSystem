using ControlSystem.Domain.Entities;

namespace ControlSystem.Test.person
{
    public class TestPerson
    {
        [Fact]
        public void Test()
        {
            Guid Id = Guid.NewGuid();
            string name = "Rafael";
            int age = 21;
            DateTime birthDay = DateTime.Parse("12/09/2002");
            string identity = "123123123";
            string individualResgistration = "12312312312";
            bool working = true;

            var person = new Person(name, age, birthDay, identity, individualResgistration, working)
            {
                Id = Id
            };

            Assert.Equal(Id, person.Id);
            Assert.Equal(name, person.Name);
            Assert.Equal(age, person.Age);
            Assert.Equal(birthDay, person.BirthDay);
            Assert.Equal(identity, person.Identity);
            Assert.Equal(individualResgistration, person.IndividualRegistration);
            Assert.Equal(working, person.Working);
        }
    }
}