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
    public class BedController : Controller
    {
        // GET: Bed
        private ApplicationDbContext _context;

        public BedController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var beds = _context.Beds.Include(b => b.Ward).ToList();

            return View(beds);
        }

        public ActionResult New()
        {
            var ward = _context.Wards.ToList();

            var viewModel = new BedFormViewModel
            {
                Bed = new Bed(),
                Wards = ward
            };

            return View("New", viewModel);
        }

        
    }
}