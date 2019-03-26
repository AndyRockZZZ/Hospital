using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.Models
{
    public class PatientOccupancy
    {
        
        public int Id { get; set; }

        public Patient Patient { get; set; }
        public int PatientId { get; set; }

        public DateTime? DateAdmitted { get; set; }

        public Ward Ward { get; set; }
        public int WardId { get; set; }

        public Bed Bed { get; set; }
        public int BedId { get; set; }

        public DateTime? DischargeDate { get; set; }

    }
}