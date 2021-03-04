using LabSupportWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LabSupportWebApp.Controllers
{
    public class UsersController : ApiController
    {
        //private StudentUser[] studentUsers = new StudentUser[]
        //{
        //    new StudentUser { Qcode = 222222, Qnum = 1, Name = @System.Security.Claims.ClaimsPrincipal.Current.FindFirst("name").Value, ElapsedTime = 0 },
        //};

        // GET: api/Users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
