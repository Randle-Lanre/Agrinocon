﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgrinoconWebApi.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string CustomerName { get; set; }

        public  WeatherInformation Weather { get; set; }

        [Display(Name = "Weather ")]
        public int WeatherInformationId { get; set; }

    }
}