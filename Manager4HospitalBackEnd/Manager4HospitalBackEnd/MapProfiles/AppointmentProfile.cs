using AutoMapper;
using DAL.Models;
using Manager4HospitalBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager4HospitalBackEnd.MapProfiles
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<Appointment, AppointmentViewModel>();
        }
    }
}
