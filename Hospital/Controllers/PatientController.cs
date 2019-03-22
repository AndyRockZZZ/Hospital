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
        public ViewResult Index()
        {
            var patients = _context.Patients.Include(p => p.Sex).Include(p => p.Status).ToList();

            return View(patients);
        }

        public ActionResult Details(int id)
        {
            var patient = _context.Patients.Include(p => p.Sex).Include(p => p.Status).SingleOrDefault(p => p.PatientId == id);

            if (patient == null)
                return HttpNotFound();

            return View(patient);
        }

        public ActionResult New()
        {
            var sex = _context.Sexes.ToList();
            var status = _context.Statuses.ToList();

            var viewModel = new PatientFormViewModel
            {
                Patient = new Patient(),
                Sexes = sex,
                Statuses = status
            };

            return View("New", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Patient patient)
        {
            if (patient.PatientId == 0)
                _context.Patients.Add(patient);

            else
            {
                var patientInDb = _context.Patients.Single(p => p.PatientId == patient.PatientId);

                patientInDb.PatientName = patient.PatientName;
                patientInDb.Address1 = patient.Address1;
                patientInDb.Address2 = patient.Address2;
                patientInDb.PostCode = patient.PostCode;
                patientInDb.SexId = patient.SexId;
                patientInDb.DOB = patient.DOB;
                patientInDb.StatusId = patient.StatusId;

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
                Sexes = _context.Sexes.ToList(),
                Statuses = _context.Statuses.ToList()
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