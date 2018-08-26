using RestWithASPNETUdemy.Data.Converters;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using Tapioca.HATEOAS.Utils;

namespace RestWithASPNETUdemy.Business.Implementattions
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _personRepository;

        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _personRepository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);

        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_personRepository.FindAll());

        }

        public List<PersonVO> FindByName(string firstName, string lastName)
        {
            return _converter.ParseList(_personRepository.FindByName(firstName, lastName));
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_personRepository.FindById(id));
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _personRepository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public PagedSearchDTO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page)
        {

            string query = @"select * from Persons p where 1 = 1 " ;
            if (!string.IsNullOrEmpty(name))
                query = query + $" and p.FirstName like '%{name}%'";

            query = query + $" order by p.FirstName {sortDirection} limit {pageSize} offset {page}";     
            
            string countQuery =  @"select count(*) from Persons p where 1 = 1 ";
            if (!string.IsNullOrEmpty(name))
                countQuery = countQuery + $" and p.FirstName like '%{name}%'";

            var persons = _personRepository.FindWithPagedSearch(query);

            var totalResults = _personRepository.GetCount(countQuery);
            return new PagedSearchDTO<PersonVO>
            {
                CurrentPage = page,
                List = _converter.ParseList(persons),
                PageSize = pageSize,
                SortDirections = sortDirection,
                TotalResults  = totalResults
            };
        }

    }
}
