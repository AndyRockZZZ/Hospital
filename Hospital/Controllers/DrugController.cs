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
    public class DrugController : Controller
    {
        // GET: Drug
        private ApplicationDbContext _context;

        public DrugController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var drugs = _context.Drugs.ToList();

            return View(drugs);
        }

        public ActionResult New()
        {
            var drug = new Drug();

            return View("New", drug);
        }

        [HttpPost]
        public ActionResult Save(Drug drug)
        {
            if (drug.DrugId == 0)
                _context.Drugs.Add(drug);

            else
            {
                var drugInDb = _context.Drugs.Single(d => d.DrugId == drug.DrugId);

                drugInDb.DrugName = drug.DrugName;
                drugInDb.Dosage = drug.Dosage;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Drug");
        }

        public ActionResult Edit(int id)
        {
            var drug = _context.Drugs.SingleOrDefault(c => c.DrugId == id);

            if (drug == null)
                return HttpNotFound();

            var viewresult = drug;

            return View("New", viewresult);

        }
    }
}