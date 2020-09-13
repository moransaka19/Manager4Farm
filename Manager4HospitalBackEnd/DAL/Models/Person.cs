using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
    }
}
