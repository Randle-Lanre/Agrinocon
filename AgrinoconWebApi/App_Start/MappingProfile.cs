using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgrinoconWebApi.Dtos;
using AgrinoconWebApi.Models;
using AutoMapper;

namespace AgrinoconWebApi.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //mapping domain to DTO
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<WeatherInformation, WeatherInformationDto>();


            //map DTOs back to the domain

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<WeatherInformationDto, WeatherInformation>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}