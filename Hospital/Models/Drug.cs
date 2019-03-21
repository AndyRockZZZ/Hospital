using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Drug
    {
        [Required]
        public int DrugId { get; set; }

        public string DrugName { get; set; }
        public float Dosage { get; set; }

    }
}