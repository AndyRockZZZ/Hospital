using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.Models
{
    public class PatientOccupancy
    {
        [Required]
        public int Id { get; set; }

        public Patient Patient { get; set; }

        [Display(Name = "Patient")]
        public int PatientId { get; set; }

        [Display(Name = "Date Admitted")]
        public DateTime? DateAdmitted { get; set; }
        
        public Ward Ward { get; set; }

        [Display(Name = "Ward")]
        public int WardId { get; set; }

        public Bed Bed { get; set; }

        [Display(Name = "Bed")]
        public int BedId { get; set; }

        [Display(Name = "Discharge Date")]
        public DateTime? DischargeDate { get; set; }

    }
}