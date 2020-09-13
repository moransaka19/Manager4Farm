using AutoMapper;
using DAL.Models;
using Manager4HospitalBackEnd.Models;

namespace Manager4HospitalBackEnd.MapProfiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, DoctorViewModel>();
        }
    }
}
