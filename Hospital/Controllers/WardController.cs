using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Hospital.Models;

namespace Hospital.Controllers
{
    public class WardController : Controller
    {
        // GET: Ward

        private ApplicationDbContext _context;

        public WardController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var wards = _context.Wards.ToList();

            return View(wards);
        }

        public ActionResult Details(int id)
        {
            var ward = _context.Wards.SingleOrDefault(w => w.WardId == id);

            if (ward == null)
            {
                return HttpNotFound();
            }

            return View(ward);
        }

        public ActionResult New()
        {
            var ward = new Ward();

            return View("New", ward);
        }

        [HttpPost]
        public ActionResult Save(Ward ward)
        {
            if (ward.WardId == 0)
                _context.Wards.Add(ward);

            else
            {
                var WardInDb = _context.Wards.Single(w => w.WardId == ward.WardId);

                WardInDb.WardName = ward.WardName;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Ward");
        }

        public ActionResult Edit(int id)
        {
            var ward = _context.Wards.SingleOrDefault(w => w.WardId == id);

            if (ward == null)
            {
                return HttpNotFound();
            }

            return View("New", ward);
        }
    }
}