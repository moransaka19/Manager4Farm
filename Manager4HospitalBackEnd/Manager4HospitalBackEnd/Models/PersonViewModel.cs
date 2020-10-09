using System;

namespace Manager4HospitalBackEnd.Models
{
    public class PersonViewModel
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public string PathToFile { get; set; }
    }
}
