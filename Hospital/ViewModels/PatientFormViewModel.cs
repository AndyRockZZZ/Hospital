using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.ViewModels
{
    public class PatientFormViewModel
    {
        public IEnumerable<Gender> Genders { get; set; }
        public IEnumerable<PatientOccupancy> PatientOccupancies { get; set; }
        public IEnumerable<Prescription> Prescriptions { get; set; }
        public IEnumerable<Ward> Wards { get; set; }
        public IEnumerable<Bed> Beds { get; set; }
        public IEnumerable<Patient> Patients { get; set; }

        public Patient Patient { get; set; }
        public PatientOccupancy PatientOccupancy { get; set; }
        public Prescription Prescription { get; set; }
        public Ward Ward { get; set; }
        public Bed Bed { get; set; }
    }
}