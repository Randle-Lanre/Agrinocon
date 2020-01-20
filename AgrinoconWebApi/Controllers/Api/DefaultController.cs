using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgrinoconWebApi.Controllers.Api
{
    public class DefaultController : ApiController
    {

        //Get api/default
        public IHttpActionResult GetTestResult()
        {
            string stringTest = "The WebAPi controller now works";
            return Ok(stringTest);
        }
    }
}
