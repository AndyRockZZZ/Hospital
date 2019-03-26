using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Hospital.Models;

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

        public ActionResult Index()
        {
            var patientoccupancies = _context.PatientOccupancies.Include(p => p.Patient).Include(p => p.Ward).Include(p => p.Bed).ToList();

            return View(patientoccupancies);
        }
    }
}