using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager4HospitalBackEnd.Models
{
    public class AppointmentViewModel
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public int ProcedureProcedureId { get; set; }
        public string ProcedureName { get; set; }
        public float ProcedurePrice { get; set; }
        public int DoctorDoctorId { get; set; }
        public string DoctorJob { get; set; }
        public int PersonPersonId { get; set; }
        public string PersonFirstname { get; set; }
        public string PersonSurname { get; set; }
        public DateTime PersonDOB { get; set; }
    }
}
