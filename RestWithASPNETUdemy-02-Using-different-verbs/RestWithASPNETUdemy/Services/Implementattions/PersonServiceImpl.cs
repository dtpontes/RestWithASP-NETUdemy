using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services.Implementattions
{
    public class PersonServiceImpl : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(long i = 0; i  <8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        
        public Person FindById(long id)
        {
            return MockPerson(id);
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(long i)
        {
            return new Person
            {
                Id = i,
                FirstName = "Nome",
                LastName = "Sobrenome " + i.ToString(),
                Address = "Rua das Rosas",
                Gender = "Male"
            };
        }



    }
}
