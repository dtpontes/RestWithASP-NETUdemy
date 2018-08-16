using RestWithASPNETUdemy.Data.Converters;
using RestWithASPNETUdemy.Data.VO;
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

        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IGenericRepository<Person> genericRepository)
        {
            _genericRepository = genericRepository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _genericRepository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _genericRepository.Delete(id);

        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_genericRepository.FindAll());

        }

        
        public PersonVO FindById(long id)
        {
            return _converter.Parse(_genericRepository.FindById(id));
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _genericRepository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
        
    }
}
