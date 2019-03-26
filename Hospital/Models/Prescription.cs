using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }

        public Patient Patient { get; set; }
        public int PatientId { get; set; }

        public Drug Drug { get; set; }
        public int DrugId { get; set; }

        public DateTime? DrugStartDate { get; set; }
        public float UnitsPerDay { get; set; }
        public DateTime? DrugEndDate { get; set; }

    }
}