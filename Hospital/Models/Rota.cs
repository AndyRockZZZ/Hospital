using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Rota
    {
        public int StaffId { get; set; }
        public int WeekNumber { get; set; }
        public int WardId { get; set; }
        public string Type { get; set; }

    }
}