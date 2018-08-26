using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Repository.Implementattions
{
    public class PersonRepositoryImpl : GenericRepository<Person>, IPersonRepository
    {       

        public PersonRepositoryImpl(MySqlContext context) : base(context)
        {  
            
        }   
        

        public List<Person> FindByName(string firstName, string lastName)
        {
            if(!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(x => x.FirstName.Equals(firstName) && x.LastName.Equals(lastName)).ToList();
            }
            else if(!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(x => x.FirstName.Equals(firstName)).ToList();
            }
            else if(string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(x =>  x.LastName.Equals(lastName)).ToList();
            }
            else
            {
                return _context.Persons.ToList();
            }

        }

        
    }
}
