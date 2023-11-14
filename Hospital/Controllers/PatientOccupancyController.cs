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
    public class PatientOccupancyController : Controller
    {
        // GET: PatientOccupancy
        private ApplicationDbContext _context;

        public PatientOccupancyController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(string searching)
        {
            return View(_context.PatientOccupancies.Include(p => p.Patient).Include(p => p.Ward).Include(p => p.Bed)
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
            var ward = _context.Wards.ToList();
            var bed = _context.Beds.ToList();

            var viewModel = new PatientFormViewModel
            {
                PatientOccupancy = new PatientOccupancy(),
                Patients = patient,
                Wards = ward,
                Beds = bed
            };

            return View("Create", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(PatientOccupancy patientOccupancy)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PatientFormViewModel
                {
                    PatientOccupancy = patientOccupancy,
                    Patients = _context.Patients.ToList(),
                    Wards = _context.Wards.ToList(),
                    Beds = _context.Beds.ToList()
                };
                return View("Create", viewModel);
            }

            if (patientOccupancy.Id == 0)
                _context.PatientOccupancies.Add(patientOccupancy);

            else
            {
                var occupancyInDb = _context.PatientOccupancies.Single(p => p.Id == patientOccupancy.Id);
                var bedInDb = _context.Beds.Single(p => p.BedId == patientOccupancy.BedId);

                occupancyInDb.PatientId = patientOccupancy.PatientId;
                occupancyInDb.DateAdmitted = patientOccupancy.DateAdmitted;
                occupancyInDb.WardId = patientOccupancy.WardId;
                occupancyInDb.BedId = patientOccupancy.BedId;
                occupancyInDb.DischargeDate = patientOccupancy.DischargeDate;
                bedInDb.IsAvailable = false;

                    var prescriptionInDb = _context.Prescriptions.Single(p => p.PatientId == patientOccupancy.PatientId);
                    var totaldrugs = _context.Drugs.Count();

                    Random random = new Random();
                    int randomdrug = random.Next(0, totaldrugs-1);
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

        public ActionResult Edit(int id)
        {
            var patient = _context.PatientOccupancies.SingleOrDefault(p => p.Id == id);

            if (patient == null)
                return HttpNotFound();

            var viewModel = new PatientFormViewModel
            {
                PatientOccupancy = patient,
                Patients = _context.Patients.ToList(),
                Wards = _context.Wards.ToList(),
                Beds = _context.Beds.ToList()
            };

            return View("Create", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var patient = _context.PatientOccupancies.SingleOrDefault(p => p.Id == id);
            var bed = _context.Beds.SingleOrDefault(p => p.BedId == patient.BedId);

            _context.PatientOccupancies.Remove(patient);
            bed.IsAvailable = true;

            _context.SaveChanges();

            return RedirectToAction("Index", "PatientOccupancy");
        }
    }
}