using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Hospital.Models;


namespace Hospital.Controllers
{
    public class RotaController : Controller
    {
        // GET: Rota
        private ApplicationDbContext _context;

        public RotaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var rota = _context.Rotas.Include(r => r.Staff).Include(r => r.Staff.StaffGrade).Include(r => r.Ward).Include(r => r.WeekShift).ToList();

            return View(rota);
        }
    }
}