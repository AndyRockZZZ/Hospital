using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Drug
    {
        
        public int DrugId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string DrugName { get; set; }

        [Required]
        [Range(0.2, 10)]
        public float Dosage { get; set; }

    }
}