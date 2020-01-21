using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgrinoconWebApi.Dtos
{
    public class WeatherInformationDto
    {

        public int Id { get; set; }

        //description is nested inside weather
        public string Description { get; set; }
        public DateTime LastSpecifiedTime { get; set; }
        public float Temperature { get; set; }
        public float WindSpeed { get; set; }

        public string Sunset { get; set; }

        public string Sunrise { get; set; }

        public string CountryCode { get; set; }

    }
}