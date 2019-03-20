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
        public string PatientName { get; set; }

        [StringLength(100)]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [StringLength(10)]
        public string PostCode { get; set; }

        public Sex Sex { get; set; }

        public int SexId { get; set; }

        public DateTime? DOB { get; set; }

        public Status Status { get; set; }

        public int StatusId { get; set; }

    }
}