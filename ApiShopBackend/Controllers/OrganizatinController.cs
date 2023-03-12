using ApiShopBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiShopBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizatinController : ControllerBase
    {
        // GET: api/<OrganizatinController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrganizatinController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrganizatinController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrganizatinController>/5
        [HttpPut("AddOrganization")]
        public void AddOrganization(string jsonStringOrganization)
        {
            Organization? organization = JsonSerializer.Deserialize<Organization>(jsonStringOrganization);
        }

        // DELETE api/<OrganizatinController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
