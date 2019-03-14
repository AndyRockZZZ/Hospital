using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Patient_Occupancy
    {
        public int PatientId { get; set; }
        public DateTime? DateAdmitted { get; set; }
        public int WardId { get; set; }
        public int BedId { get; set; }
        public DateTime? DischargeDate { get; set; }

    }
}