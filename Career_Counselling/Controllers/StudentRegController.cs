using Career_Counselling.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Career_Counselling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegController : ControllerBase
    {


        StudentRegDB dbobj = new StudentRegDB();
            
        // GET: api/<StudentRegController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentRegController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentRegController>
        [HttpPost]
        public void Post([FromBody] StudentReg objcls)
        {
            dbobj.InsertDB(objcls);
        }

        // PUT api/<StudentRegController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentRegController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
