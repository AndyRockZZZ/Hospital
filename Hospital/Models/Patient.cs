using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Required]
        [StringLength(70)]
        [Display(Name = "First Name")]
        public string PatientFirstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string PatientSurname { get; set; }

        [Required]
        [StringLength(100)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(100)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(10)]
        public string PostCode { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime? DOB { get; set; }

        public Gender Gender { get; set; }

        [Display(Name = "Gender")]
        public int GenderId { get; set; }

    }
}