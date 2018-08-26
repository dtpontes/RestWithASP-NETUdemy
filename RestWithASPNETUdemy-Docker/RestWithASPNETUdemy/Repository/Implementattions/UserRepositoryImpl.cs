using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Repository.Implementattions
{
    public class UserRepositoryImpl : IUserRepository
    {
        private MySqlContext _context;

        public UserRepositoryImpl(MySqlContext context)
        {
            _context = context;
        }    

        
        public User FindByLogin(string login)
        {
            return _context.Users.SingleOrDefault(x => x.Login.Equals(login));
        }

        

       
    }
}
