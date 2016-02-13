using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using runnertrails.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace runnertrails.Controllers
{
    [Route("api/[controller]")]
    public class RunnersController : Controller
    {
        // GET: api/values
        [HttpGet]
        public Runner[] Get()
        {
            var runners = new List<Runner>();
            
            runners.Add(new Runner() {Id=1,First="Matthew",Last="Baskey", Age=44,FavoriteBeer="Pabst"});
            runners.Add(new Runner() {Id=2,First="Joe",Last="Baskey", Age=23,FavoriteBeer="guniess"});
            runners.Add(new Runner() {Id=3,First="Butch",Last="Baskey", Age=33,FavoriteBeer="pilsner"});
            // return new string[] { "value1", "value2" };
            // dsfgsdfg
            return runners.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return Get().Where(r=>r.Id==id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
