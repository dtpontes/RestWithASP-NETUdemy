using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Business.Implementattions
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _personRepository;

        public PersonBusinessImpl(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(Person person)
        {           
            return _personRepository.Create(person);
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);
            
        }

        public List<Person> FindAll()
        {
            return _personRepository.FindAll();
        }

        
        public Person FindById(long id)
        {
            return _personRepository.FindById(id);
        }

        public Person Update(Person person)
        {           
            return _personRepository.Update(person);
        }
        
    }
}
