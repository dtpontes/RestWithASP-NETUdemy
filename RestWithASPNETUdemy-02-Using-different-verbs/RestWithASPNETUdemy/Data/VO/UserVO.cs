﻿using RestWithASPNETUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tapioca.HATEOAS;

namespace RestWithASPNETUdemy.Data.VO
{
    public class UserVO 
    {        
        public string Login { get; set; }

        public string AccessKey { get; set; }      

        
    }
}
