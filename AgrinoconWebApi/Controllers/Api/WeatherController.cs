using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgrinoconWebApi.Controllers.Api
{
    public class WeatherController : ApiController
    {

        //Get api/weather
        //TODO: add paramenter for user to supply optional location infomation or use default
        [Route("api/getcurrentwether")]
        public IHttpActionResult GetCurrentWeather()
        {
            string stringTest = "The WebAPi controller now works";
            return Ok(stringTest);
        }

        //TODO:add authorization
        [HttpPost]
        public IHttpActionResult CreateLocationPreference()
        {
            string stringtest = "posted";

            return Ok(stringtest);
            //return Created(new Uri(Request.RequestUri + "/" +), )
        }

        //TODO:add authorization
        [HttpPut]
        public IHttpActionResult UpdateWeather()
        {
            string stringtest = "Put successful";

            return Ok(stringtest);
        }

        //TODO:add authorization with specified roles
        [HttpDelete]
        public IHttpActionResult DeleteWeather()
        {

            string stringtest = "sucessfully deleted";
            return Ok(stringtest);
        }


    }
}
