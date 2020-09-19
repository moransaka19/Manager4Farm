using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories;
using Manager4HospitalBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Manager4HospitalBackEnd.Controllers
{
    [Route("api/journal")]
    [ApiController]
    public class JournalController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;

        public JournalController(IMapper mapper, IAppointmentRepository appointmentRepository)
        {
            _mapper = mapper;
            _appointmentRepository = appointmentRepository;
        }

        [HttpGet]   
        public IEnumerable<AppointmentViewModel> Get()
        {
            return _mapper.Map<IEnumerable<AppointmentViewModel>>(_appointmentRepository.GetAll());
        }
    }
}
