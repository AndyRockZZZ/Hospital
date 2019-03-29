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

        public ViewResult Index()
        {
            var patientoccupancies = _context.PatientOccupancies.Include(p => p.Patient).Include(p => p.Ward).Include(p => p.Bed).ToList();

            return View(patientoccupancies);
        }

        public ActionResult New()
        {
            var patient = _context.Patients.ToList();
            var ward = _context.Wards.ToList();
            var bed = _context.Beds.ToList();
            

            var viewModel = new PatientFormViewModel
            {
                PatientOccupancy = new PatientOccupancy(),
                Wards = ward,
                Beds = bed,
                Patients = patient,
            };

            return View("New", viewModel);
        }

        [HttpPost]
        public ActionResult Save(PatientOccupancy patientOccupancy)
        {
            if (patientOccupancy.Id == 0)
                _context.PatientOccupancies.Add(patientOccupancy);

            else
            {
                var patientOccupancyInDb = _context.PatientOccupancies.Single(p => p.Id == patientOccupancy.Id);

                patientOccupancyInDb.PatientId = patientOccupancy.PatientId;
                patientOccupancyInDb.DateAdmitted = DateTime.Now;
                patientOccupancyInDb.Ward.WardId = patientOccupancy.Ward.WardId;
                patientOccupancyInDb.Bed.Ward.WardId = patientOccupancy.Ward.WardId;
                patientOccupancyInDb.Bed.BedId = patientOccupancy.Bed.BedId;
                patientOccupancyInDb.DischargeDate = patientOccupancy.DischargeDate;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "PatientOccupancy");
        }
    }
}