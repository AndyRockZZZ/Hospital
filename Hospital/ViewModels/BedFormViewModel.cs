using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.ViewModels
{
    public class BedFormViewModel
    {
        public Bed Bed { get; set; }
        public IEnumerable<Ward> Wards { get; set; }
    }
}