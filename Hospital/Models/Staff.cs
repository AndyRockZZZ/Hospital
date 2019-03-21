using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int PhoneNumber { get; set; }

        public StaffGrade StaffGrade { get; set; }

        public int StaffGradeId { get; set; }

    }
}