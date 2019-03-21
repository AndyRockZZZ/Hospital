using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.ViewModels
{
    public class StaffFormViewModel
    {
        public IEnumerable<StaffGrade> Grades { get; set; }
        public Staff Staff { get; set; }
    }
}