using Microsoft.AspNetCore.Mvc;
using Career_Counselling.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Career_Counselling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminRegController : ControllerBase
    {
        AdminRegDB dbobj=new AdminRegDB();

        // GET: api/<AdminRegController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AdminRegController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AdminRegController>
        [HttpPost]
        public void Post([FromBody] AdminReg objcls)
        {
            dbobj.InsertDB(objcls);
        }

        // PUT api/<AdminRegController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AdminRegController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
