using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralInfoController : ControllerBase
    {

        IGeneralInfo _generalInfo;

        public GeneralInfoController(IGeneralInfo generalInfo)
        {
            _generalInfo = generalInfo;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_generalInfo.Get());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult GetDetails(int id)
        {
            return Ok(_generalInfo.GetDetails(id));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] GeneralInfo info)
        {
            _generalInfo.Save(info);
            return Ok();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] GeneralInfo info)
        {
            _generalInfo.Update(info,id);
            return Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public  IActionResult Delete(int id)
        {
            _generalInfo.Delete(id);
            return Ok();
        }
    }
}
