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
    public class LoginBusinessImpl : ILoginBusiness
    {
        private IUserRepository _userRepository;        

        public LoginBusinessImpl(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            
        }
                
        public User FindByLogin(string login)
        {
            return _userRepository.FindByLogin(login);
        }       
        
    }
}
