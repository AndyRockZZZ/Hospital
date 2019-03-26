using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.ViewModels
{
    public class PatientFormViewModel
    {
        public IEnumerable<Sex> Sexes { get; set; }
        public IEnumerable<Status> Statuses { get; set; }

        public Patient Patient { get; set; }
        public IEnumerable<PatientOccupancy> PatientOccupancy { get; set; }
        public IEnumberable<Prescription> Prescription { get; set; }
    }
}