using AutoMapper;
using DAL.Models;
using Manager4HospitalBackEnd.MapProfiles.Resolvers;
using Manager4HospitalBackEnd.Models;

namespace Manager4HospitalBackEnd.MapProfiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonViewModel>()
                .ForMember(data => data.PathToFile,
                           opt => opt.MapFrom<PersonResolver>());
        }
    }
}
