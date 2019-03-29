using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Patient
    {
        [Required]
        public int PatientId { get; set; }

        [StringLength(70)]
        public string PatientFirstName { get; set; }
        public string PatientSurname { get; set; }

        [StringLength(100)]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [StringLength(10)]
        public string PostCode { get; set; }

        public DateTime? DOB { get; set; }

        public Gender Gender { get; set; }
        public int GenderId { get; set; }

    }
}