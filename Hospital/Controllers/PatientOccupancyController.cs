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
        public ActionResult Save(PatientOccupancy occupancy)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PatientFormViewModel
                {
                    PatientOccupancy = occupancy,
                    Patients = _context.Patients.ToList(),
                    Wards = _context.Wards.ToList(),
                    Beds = _context.Beds.ToList()
                };
                return View("Create", viewModel);
            }
            if (occupancy.Id == 0)
                _context.PatientOccupancies.Add(occupancy);

            else
            {
                var occupancyInDb = _context.PatientOccupancies.Single(p => p.Id == occupancy.Id);

                occupancyInDb.PatientId = occupancy.PatientId;
                occupancyInDb.DateAdmitted = occupancy.DateAdmitted;
                occupancyInDb.WardId = occupancy.WardId;
                occupancyInDb.BedId = occupancy.BedId;
                occupancyInDb.DischargeDate = occupancy.DischargeDate;
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
    }
}