﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgrinoconWebApi.Models
{
    public class WeatherInformation
    {

        public int Id { get; set; }

        //description is nested inside weather
        public string Description { get; set; }
        public DateTime LastSpecifiedTime{ get; set; }
        public float Temperature { get; set; }
        public float WindSpeed { get; set; }

        public string Sunset { get; set; }

        public string Sunrise { get; set; }

        public string CountryCode { get; set; }


        #region extraApiParameters





        //public class Rootobject
        //{
        //    public Datum[] data { get; set; }
        //    public int count { get; set; }
        //}

        //public class Datum
        //{
        //    public int rh { get; set; }
        //    public string pod { get; set; }
        //    public float lon { get; set; }
        //    public float pres { get; set; }
        //    public string timezone { get; set; }
        //    public string ob_time { get; set; }
        //    
        //    public int clouds { get; set; }
        //    public int ts { get; set; }
        //    public int solar_rad { get; set; }
        //    public string state_code { get; set; }
        //    public string city_name { get; set; }
        //    

        //    public string wind_cdir_full { get; set; }
        //    public string wind_cdir { get; set; }
        //    public float slp { get; set; }
        //    public float vis { get; set; }
        //    public int h_angle { get; set; }
        //    public string sunset { get; set; }
        //    public int dni { get; set; }
        //    public float dewpt { get; set; }
        //    public int snow { get; set; }
        //    public int uv { get; set; }
        //    public int precip { get; set; }
        //    public int wind_dir { get; set; }
        //    
        //    public int ghi { get; set; }
        //    public int dhi { get; set; }
        //    public int aqi { get; set; }
        //    public float lat { get; set; }
        //    public Weather weather { get; set; }
        //    public string datetime { get; set; }
        //    
        //    public string station { get; set; }
        //    public float elev_angle { get; set; }
        //    public float app_temp { get; set; }
        //}

        //public class Weather
        //{

        //    public string description { get; set; }
        //}
        #endregion
    }
}