using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CelsaWS.Controllers
{
    public class LDAPController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            return Ok("ds");
        }

    }
}
