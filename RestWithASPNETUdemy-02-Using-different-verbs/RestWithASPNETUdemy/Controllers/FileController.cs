using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Data.VO;
using Tapioca.HATEOAS;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class FileController : Controller
    {
        private IFileBusiness _fileBusiness;

        public FileController(IFileBusiness fileBusiness)
        {
            _fileBusiness = fileBusiness;
        }





        // POST api/values        
        [HttpPost]
        [ProducesResponseType(typeof(byte[]), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post()
        {

            byte[] buffer = _fileBusiness.GetPDFFIle();

            if(buffer != null)
            {
                HttpContext.Response.ContentType = "application/pdf";
                HttpContext.Response.Headers.Add("context-lenght", buffer.Length.ToString());
                HttpContext.Response.Body.Write(buffer, 0, buffer.Length);
            }

            return new ContentResult();
            
        }      

        
    }
}
