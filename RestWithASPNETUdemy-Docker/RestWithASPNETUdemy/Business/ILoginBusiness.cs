﻿using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface ILoginBusiness
    {
        object FindByLogin(UserVO user);       
    }
}
