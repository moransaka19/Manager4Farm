using AutoMapper;
using DAL.Models;
using Manager4HospitalBackEnd.Models;

namespace Manager4HospitalBackEnd.MapProfiles
{
    public class ProcedureProfile : Profile
    {
        public ProcedureProfile()
        {
            CreateMap<Procedure, ProcedureViewModel>();
        }
    }
}
