using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Hospital.Models;
using Hospital.ViewModels;
using System.Threading.Tasks;

namespace Hospital.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient

        private ApplicationDbContext _context;

        public PatientController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(string searching)
        {
            return View(_context.Patients.Include(p => p.Gender)
                .Where(p => p.PatientSurname.StartsWith(searching) 
                || searching == null));
        }

        [HttpPost]
        public string Search(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        public ActionResult Details(int id)
        {
            var patient = _context.Patients.Include(p => p.Gender).SingleOrDefault(p => p.PatientId == id);
            var occupancy = _context.PatientOccupancies.Include(p => p.Patient).Include(p => p.Ward).Include(p => p.Bed).SingleOrDefault(p => p.PatientId == id);
            var prescription = _context.Prescriptions.Include(p => p.Drug).SingleOrDefault(p => p.PatientId == id);

            if (patient == null)
                return HttpNotFound();

            var viewModel = new PatientFormViewModel
            {
                Patient = patient,
                PatientOccupancy = occupancy,
                Prescription = prescription
            };

            return View(viewModel);
        }

        public ActionResult New()
        {
            var gender = _context.Genders.ToList();

            var viewModel = new PatientFormViewModel
            {
                Patient = new Patient(),
                Genders = gender
            };

            return View("New", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PatientFormViewModel
                {
                    Patient = patient,
                    Genders = _context.Genders.ToList()
                };
                return View("New", viewModel);
            }
            if (patient.PatientId == 0)
                _context.Patients.Add(patient);

            else
            {
                var patientInDb = _context.Patients.Single(p => p.PatientId == patient.PatientId);

                patientInDb.PatientFirstName = patient.PatientFirstName;
                patientInDb.PatientSurname = patient.PatientSurname;
                patientInDb.Address1 = patient.Address1;
                patientInDb.Address2 = patient.Address2;
                patientInDb.PostCode = patient.PostCode;
                patientInDb.DOB = patient.DOB;
                patientInDb.GenderId = patient.GenderId;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Patient");
        }

        public ActionResult Edit(int id)
        {
            var patient = _context.Patients.SingleOrDefault(p => p.PatientId == id);

            if (patient == null)
                return HttpNotFound();

            var viewModel = new PatientFormViewModel
            {
                Patient = patient,
                Genders = _context.Genders.ToList()
            };

            return View("New", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var patient = _context.Patients.SingleOrDefault(p => p.PatientId == id);

            var delete = _context.Patients.Remove(patient);

            _context.SaveChanges();

            return RedirectToAction("Index", "Patient");
        }
    }
}