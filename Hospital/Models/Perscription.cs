using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Perscription
    {
        public int PatientId { get; set; }
        public int DrugId { get; set; }
        public DateTime? DrugStartDate { get; set; }
        public int UnitsPerDay { get; set; }
        public DateTime? DrugEndDate { get; set; }

    }
}