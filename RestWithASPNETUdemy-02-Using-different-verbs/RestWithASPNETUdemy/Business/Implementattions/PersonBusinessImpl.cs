using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Business.Implementattions
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IGenericRepository<Person> _genericRepository;

        public PersonBusinessImpl(IGenericRepository<Person> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Person Create(Person person)
        {
            return _genericRepository.Create(person);
        }

        public void Delete(long id)
        {
            _genericRepository.Delete(id);

        }

        public List<Person> FindAll()
        {
            return _genericRepository.FindAll();
        }

        
        public Person FindById(long id)
        {
            return _genericRepository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _genericRepository.Update(person);
        }
        
    }
}
