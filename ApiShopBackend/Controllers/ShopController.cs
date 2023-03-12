using ApiShopBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Nodes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiShopBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        // GET: api/<ShopController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ShopController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShopController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShopController>/5
        [HttpPut("{id}")]
        public void Put(string jsonString)
        {
            Shop shop = JsonSerializer.Deserialize<Shop>(jsonString);



        }

        // DELETE api/<ShopController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
