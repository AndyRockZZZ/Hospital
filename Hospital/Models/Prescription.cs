using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.Models
{
    public class Prescription
    {
        [Required]
        public int PrescriptionId { get; set; }

        public Patient Patient { get; set; }

        [Display(Name = "Patient")]
        public int PatientId { get; set; }

        public Drug Drug { get; set; }

        [Display(Name = "Drug")]
        public int DrugId { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? DrugStartDate { get; set; }

        [Display(Name = "Units Per Day")]
        public float UnitsPerDay { get; set; }

        [Display(Name = "End Date")]
        public DateTime? DrugEndDate { get; set; }

    }
}