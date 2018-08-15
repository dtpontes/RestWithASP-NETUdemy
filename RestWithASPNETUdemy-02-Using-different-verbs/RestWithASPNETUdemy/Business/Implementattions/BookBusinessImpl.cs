using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Business.Implementattions
{
    public class BookBusinessImpl : IBookBusiness
    {
        private IGenericRepository<Book> _genericRepository;

        public BookBusinessImpl(IGenericRepository<Book> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Book Create(Book book)
        {           
            return _genericRepository.Create(book);
        }

        public void Delete(long id)
        {
            _genericRepository.Delete(id);
            
        }

        public List<Book> FindAll()
        {
            return _genericRepository.FindAll();
        }

        
        public Book FindById(long id)
        {
            return _genericRepository.FindById(id);
        }

        public Book Update(Book book)
        {           
            return _genericRepository.Update(book);
        }
        
    }
}
