using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.ViewModels
{
    public class WardFormViewModel
    {
        public Ward Ward { get; set; }
        public IEnumerable<Bed> Beds { get; set; }
    }
}