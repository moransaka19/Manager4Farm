using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Azure.Storage.Blobs;
using DAL.Repositories;
using Manager4HospitalBackEnd.AzureStorage;
using Manager4HospitalBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Manager4HospitalBackEnd.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        private readonly IAzureBlobService _azureBlobService;

        public PersonController(IPersonRepository personRepository,
            IMapper mapper, IAzureBlobService azureBlobService)
        {
            _personRepository = personRepository;
            _mapper = mapper;
            _azureBlobService = azureBlobService;
        }

        [HttpGet]
        public IEnumerable<PersonViewModel> Get()
        {
            return _mapper.Map<IEnumerable<PersonViewModel>>(_personRepository.GetAll());
        }

        [Route("pic/{fileName}")]
        [HttpPost]
        public string GetPicture(string fileName)
        {
            return _azureBlobService.Download(fileName);
        }
    }
}
