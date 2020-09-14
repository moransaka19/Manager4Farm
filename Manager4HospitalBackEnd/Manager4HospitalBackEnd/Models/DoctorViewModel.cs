using System;

namespace Manager4HospitalBackEnd.Models
{
    public class DoctorViewModel
    {
        public int DoctorId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public string Job { get; set; }
    }
}
