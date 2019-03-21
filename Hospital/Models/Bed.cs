using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Bed
    {
        public Ward Ward { get; set; }
        public int WardId { get; set; }

        public int BedId { get; set; }
        public bool IsAvailable { get; set; }
    }
}