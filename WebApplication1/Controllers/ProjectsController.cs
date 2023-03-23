using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using WebApplication1.Interfaces;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        IProjects _project;

        public ProjectsController(IProjects project)
        {
            _project = project;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_project.Get());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult GetDetails(int id)
        {
            return Ok(_project.GetDetails(id));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] Projects project)
        {
            _project.Save(project);
            return Ok();

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Projects project)
        {
            _project.Update(project, id);
            return Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _project.Delete(id);
            return Ok();
        }
    }
}
