using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Script.Serialization;
using AgrinoconWebApi.Dtos;
using AgrinoconWebApi.Models;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AgrinoconWebApi.Controllers.Api
{
    public class WeatherController : ApiController
    {
        private ApplicationDbContext _context;

        public WeatherController()
        {
            _context = new ApplicationDbContext();
        }

        static HttpClient http = new HttpClient();


        //Get api/weather

        [Route("api/getcurrentwether")]
        public async Task<IHttpActionResult> GetCurrentWeather(String city = "Dublin", String country = "Ireland")
        {
            var getApiKey = Environment.GetEnvironmentVariable("WEATHERAPIKEY");

            var fetchWeatherInformation =
                $"https://api.weatherbit.io/v2.0/current?city={city}&country={country}&key={getApiKey}";



            var response = await http.GetAsync(fetchWeatherInformation);


            var content = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(content);


            return Ok(json);

        }


        //TODO:add authorization
        [HttpPost]
        public IHttpActionResult CreateLocationPreference(WeatherInformationDto weatherInformationDto)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            var weather = Mapper.Map<WeatherInformationDto, WeatherInformation>(weatherInformationDto);
            _context.WeatherInformations.Add(weather);
            _context.SaveChanges();


            weatherInformationDto.Id = weather.Id;


            return Created(new Uri(Request.RequestUri + "/" + weather.Id), weatherInformationDto);


        }

        //TODO:add authorization
        //PUT api/weather/1
        [HttpPut]
        public IHttpActionResult UpdateWeather(int id, WeatherInformationDto weatherInformationDto)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            var weatherInformationInDb = _context.WeatherInformations.SingleOrDefault(w => w.Id == id);

            if (weatherInformationInDb == null)
                return NotFound();
            Mapper.Map(weatherInformationDto, weatherInformationInDb);

            _context.SaveChanges();
            return Ok();


        }

        //TODO:add authorization with specified roles
        //DELETE  api/weather/1
        [HttpDelete]
        public IHttpActionResult DeleteWeather(int id)
        {
            var weatherInformationInDb = _context.WeatherInformations.SingleOrDefault(w => w.Id == id);

            if (weatherInformationInDb == null)
                return NotFound();
            _context.WeatherInformations.Remove(weatherInformationInDb);
            _context.SaveChanges();
            return Ok();
            //string stringtest = "sucessfully deleted";
            //return Ok(stringtest);
        }


    }
}
