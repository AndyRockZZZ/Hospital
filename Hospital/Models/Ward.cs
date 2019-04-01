using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Ward
    {
        
        public int WardId { get; set; }

        [Required]
        [StringLength(70)]
        [Display(Name = "Name")]
        public string WardName { get; set; }
    }
}