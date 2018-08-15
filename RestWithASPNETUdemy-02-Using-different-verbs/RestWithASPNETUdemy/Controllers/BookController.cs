using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Controllers
{    
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : Controller
    {
        private IPersonBusiness _personBusiness;

        public BookController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            //return Ok(_personBusiness.FindAll());
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            //var person = _personBusiness.FindById(id);
            //if (person == null) return NotFound();
            //return Ok(person);

            return Ok();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {
            
            //if (person == null) return BadRequest();
            //return new ObjectResult(_personBusiness.Create(person));

            return Ok();
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]Person person)
        {
            //if (person == null) return BadRequest();
            //var updatePerson = _personBusiness.Update(person);
            //if (updatePerson == null) return NoContent();
            //return new ObjectResult(updatePerson);

            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            //_personBusiness.Delete(id);
            //return NoContent();

            return Ok();
        }
    }
}
