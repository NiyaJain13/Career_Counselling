using Microsoft.AspNetCore.Mvc;
using Career_Counselling.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Career_Counselling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeRegController : ControllerBase
    {

        CollegeRegDB dbobj = new CollegeRegDB();


        // GET: api/<CollegeRegController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CollegeRegController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CollegeRegController>
        [HttpPost]
        public void Post([FromBody] CollegeReg obcls)
        {
            dbobj.InsertDB(obcls);


        }

        // PUT api/<CollegeRegController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CollegeRegController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
