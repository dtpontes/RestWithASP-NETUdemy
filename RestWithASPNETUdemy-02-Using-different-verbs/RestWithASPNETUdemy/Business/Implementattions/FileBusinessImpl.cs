using Microsoft.IdentityModel.Tokens;
using RestWithASPNETUdemy.Data.Converters;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Repository.Generic;
using RestWithASPNETUdemy.Security.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace RestWithASPNETUdemy.Business.Implementattions
{
    public class FileBusinessImpl : IFileBusiness
    {
        public byte[] GetPDFFIle()
        {
            string path = Directory.GetCurrentDirectory();
            var fullPAth = path + "\\Other\\teste.pdf";
            return File.ReadAllBytes(fullPAth);
        }
    }
}
