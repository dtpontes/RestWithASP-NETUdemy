﻿using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Repository.Implementattions
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        private MySqlContext _context;

        public PersonRepositoryImpl(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Person.SingleOrDefault(x => x.Id.Equals(id));

            try
            {
                if(result != null)
                {
                    _context.Person.Remove(result);
                    _context.SaveChanges();
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<Person> FindAll()
        {
            return _context.Person.ToList();
        }

        
        public Person FindById(long id)
        {
            return _context.Person.SingleOrDefault(x => x.Id == id);
        }

        public Person Update(Person person)
        {
            if (!Exist(person.Id)) return new Person();

            var result = _context.Person.SingleOrDefault(x => x.Id.Equals(person.Id));

            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public bool Exist(long? id)
        {
            return _context.Person.Any(x => x.Id.Equals(id));
        }
    }
}
