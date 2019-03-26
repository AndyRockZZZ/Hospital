using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Hospital.Models;

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

        public ViewResult Index()
        {
            var prescriptions = _context.Prescriptions.Include(p => p.Patient).Include(p => p.Drug).ToList();

            return View(prescriptions);
        }
    }
}