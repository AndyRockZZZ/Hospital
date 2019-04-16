using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Hospital.Models;
using Hospital.ViewModels;

namespace Hospital.Controllers
{
    public class PrescriptionController : Controller
    {
        // GET: Prescription
        private ApplicationDbContext _context;

        public PrescriptionController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(string searching)
        {
            return View(_context.Prescriptions.Include(p => p.Patient).Include(p => p.Drug)
                .Where(p => p.Patient.PatientSurname.StartsWith(searching)
                || searching == null));
        }

        [HttpPost]
        public string Search(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        public ActionResult Create()
        {
            var patient = _context.Patients.ToList();
            

            return View("Create", patient);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Prescription prescription)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PatientFormViewModel
                {
                    Prescription = prescription,
                    Patients = _context.Patients.ToList(),
                    Drug = _context.Drugs.ToList()
                };
                return View("Create", viewModel);
            }

            if (prescription.PrescriptionId == 0)
                _context.PatientOccupancies.Add();

            else
            { 
                var prescriptionInDb = _context.Prescriptions.Single(p => p.PatientId == patientOccupancy.PatientId);
                var totaldrugs = _context.Drugs.Count();

                Random random = new Random();
                int randomdrug = random.Next(0, totaldrugs - 1);
                var minimum = 0.1;
                var maximum = 10.0;
                var randomUnitPerDay = random.NextDouble() * (maximum - minimum) + minimum;
                var startdate = random.Next(0, 1);
                var enddate = random.Next(-1, 0);

                prescriptionInDb.PatientId = patientOccupancy.PatientId;
                prescriptionInDb.DrugId = randomdrug;
                prescriptionInDb.DrugStartDate = patientOccupancy.DateAdmitted.Value.AddDays(startdate);
                prescriptionInDb.UnitsPerDay = randomUnitPerDay;
                prescriptionInDb.DrugEndDate = patientOccupancy.DischargeDate.Value.AddDays(enddate);

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "PatientOccupancy");
        }
    }
}