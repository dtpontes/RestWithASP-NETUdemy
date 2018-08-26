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
    public class BookBusinessImpl : IBookBusiness
    {
        private IGenericRepository<Book> _genericRepository;

        private readonly BookConverter _converter;

        public BookBusinessImpl(IGenericRepository<Book> genericRepository)
        {
            _genericRepository = genericRepository;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _genericRepository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public void Delete(long id)
        {
            _genericRepository.Delete(id);
            
        }

        public List<BookVO> FindAll()
        {
            return _converter.ParseList(_genericRepository.FindAll());
        }

        
        public BookVO FindById(long id)
        {
            return _converter.Parse(_genericRepository.FindById(id));
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _genericRepository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        
    }
}
