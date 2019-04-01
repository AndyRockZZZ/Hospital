using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Rota
    {
        [Required]
        [Display(Name = "Rota Number")]
        public int RotaId { get; set; }

        public Staff Staff { get; set; }

        [Display(Name = "Staff Member")]
        public int StaffId { get; set; }

        public Ward Ward { get; set; }

        [Display(Name = "Ward")]
        public int WardId { get; set; }

        public WeekShift WeekShift { get; set; }

        [Display(Name = "Week Shift")]
        public int WeekShiftId { get; set; }
        

    }
}