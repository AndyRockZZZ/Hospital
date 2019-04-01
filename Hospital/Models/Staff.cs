using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.Models
{
    public class Staff
    {
        public int StaffId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string StaffName { get; set; }

        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        public StaffGrade StaffGrade { get; set; }

        [Display(Name = "Grade")]
        public int StaffGradeId { get; set; }

    }
}