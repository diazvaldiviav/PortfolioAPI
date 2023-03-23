using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        IClientService _clientService;


        public ClientsController(IClientService clientService)
        {
            this._clientService = clientService;

        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientService.Get());
        }

        // GET: api/<ValuesController>
        [HttpGet("{id}")]
        public IActionResult GetDetails(int id)
        {
            return Ok(_clientService.GetDetails(id));
        }

        // Post api/<ValuesController>/5
        [HttpPost]
        public IActionResult Post([FromBody] Clients client)
        {
            _clientService.Save(client);
            return Ok();
        }

        // PUT api/<ValuesController>
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Clients client, int id)
        {
            _clientService.Update(client, id);
            return Ok();
        }

        

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clientService.Delete(id);
            return Ok();
        }
    }
}
