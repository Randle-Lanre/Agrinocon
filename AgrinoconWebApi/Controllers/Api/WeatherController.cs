using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Script.Serialization;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AgrinoconWebApi.Controllers.Api
{
    public class WeatherController : ApiController
    {
        


        //Get api/weather
        //TODO: add paramenter for user to supply optional location infomation or use default
        [Route("api/getcurrentwether")]
        public async Task<IHttpActionResult> GetCurrentWeather(String city = "Dublin", String country = "Ireland")
        {
            var fetchWeatherInformation =
                $"https://api.weatherbit.io/v2.0/current?city={city}&country={country}&key=641b68d48f654b0b874686e073372c24";

            var http = new HttpClient();

            var response = await http.GetAsync(fetchWeatherInformation);


            var content = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(content);


            return Ok(json);

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
