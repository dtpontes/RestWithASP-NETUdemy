using RestWithASPNETUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    public class Book : BaseEntity
    {

        public string Title { get; set; }

        public string Author { get; set; }
   
        public string Price { get; set; }

        public DateTime LaunchDate { get; set; }
    }
}
