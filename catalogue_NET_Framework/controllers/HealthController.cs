using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace catalogue.Controllers
{
    public class HealthController : ApiController
    {
        public IHttpActionResult gethealth()
        {
            return Ok("ok");
        }
    }
}
