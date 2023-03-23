using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoController : ControllerBase
    {
        IContacto _contacto;

        public ContactoController(IContacto contacto)
        {
            this._contacto = contacto;
        }        
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_contacto.Get());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult GetDetails(int id)
        {

            return Ok(_contacto.GetDetails(id));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] Contacto contacto)
        {
            _contacto.Save(contacto);
            return Ok();

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Contacto contacto)
        {
            _contacto.Update(contacto, id);
            return Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contacto.Delete(id);
            return Ok();

        }
    }
}
