using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIWithAuth.Models;

namespace WebAPIWithAuth.Controllers
{
  // [Authorize(Roles ="Member, Admin")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            db_nameEntities1 _cntx = new db_nameEntities1();
            var item = _cntx.QUOTES.ToList();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
       [Route("myown")]      // http:localhost:4545/myown
       [HttpGet]

        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route("custom")]
        public void Custom([FromBody]string value)
        {
        }
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
