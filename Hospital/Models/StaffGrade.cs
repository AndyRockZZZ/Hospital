using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class StaffGrade
    {
        public int Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }
    }
}