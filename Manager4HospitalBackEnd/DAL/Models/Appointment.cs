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
        public Procedure Procedure { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
