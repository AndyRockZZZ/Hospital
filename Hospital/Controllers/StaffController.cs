using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Hospital.Models;
using Hospital.ViewModels;

namespace Hospital.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        private ApplicationDbContext _context;

        public StaffController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var staffs = _context.Staffs.Include(s => s.StaffGrade).ToList();

            return View(staffs);
        }

        public ActionResult Details(int id)
        {
            var staff = _context.Rotas.Include(s => s.Staff).Include(s => s.Staff.StaffGrade).Include(r => r.Ward).Include(r => r.WeekShift).ToList().Where(s => s.StaffId == id);

            if (staff == null)
                return HttpNotFound();

            return View(staff);
        }

        public ActionResult New()
        {
            var staffgrade = _context.StaffGrades.ToList();

            var viewModel = new StaffFormViewModel
            {
                Staff = new Staff(),
                Grades = staffgrade
            };

            return View("New", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Staff staff)
        {
            if (staff.StaffId == 0)
            {
               _context.Staffs.Add(staff);
            }

            else
            {
                var StaffInDb = _context.Staffs.Single(s => s.StaffId == staff.StaffId);

                StaffInDb.StaffName = staff.StaffName;
                StaffInDb.StaffGradeId = staff.StaffGradeId;

                if (StaffInDb.PhoneNumber == 0)
                {
                    Random random = new Random();
                    int number = random.Next(1, 99);

                    StaffInDb.PhoneNumber = number;
                }
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Staff");
        }

        public ActionResult Edit(int id)
        {
            var staff = _context.Staffs.SingleOrDefault(s => s.StaffId == id);

            if (staff == null)
                return HttpNotFound();

            var viewModel = new StaffFormViewModel
            {
                Staff = staff,
                Grades = _context.StaffGrades.ToList()
            };

            return View("New", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var staff = _context.Staffs.SingleOrDefault(s => s.StaffId == id);

            _context.Staffs.Remove(staff);

            _context.SaveChanges();

            return RedirectToAction("Index", "Staff");
        }
    }
}