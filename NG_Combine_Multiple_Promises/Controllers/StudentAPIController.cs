using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NG_Combine_Multiple_Promises.Models;
using System.Web.Http.Cors;

namespace NG_Combine_Multiple_Promises.Controllers
{
    [EnableCors("*", "*", "*")]
    public class StudentAPIController : ApiController
    {
        [Route("Students")]
        public IEnumerable<Student> Get()
        {
            return new StudentDatabase();
        }
    }
}
