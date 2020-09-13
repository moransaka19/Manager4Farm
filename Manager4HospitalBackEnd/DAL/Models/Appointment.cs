using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public int ProcedureId { get; set; }
        public int DoctorId { get; set; }
        public int PersonId { get; set; }
    }
}
