using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Rota
    {
        public int RotaId { get; set; }

        public Staff Staff { get; set; }

        public int StaffId { get; set; }

        public Ward Ward { get; set; }

        public int WardId { get; set; }

        public WeekShift WeekShift { get; set; }

        public int WeekShiftId { get; set; }
        

    }
}