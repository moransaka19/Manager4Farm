﻿using AutoMapper;
using DAL.Models;
using Manager4HospitalBackEnd.Models;

namespace Manager4HospitalBackEnd.MapProfiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonViewModel>();
        }
    }
}
