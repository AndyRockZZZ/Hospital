using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital.Models;

namespace Hospital.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ViewResult Index()
        {
            var patients = GetPatients();
            return View(patients);
        }

        public ActionResult Details(int id)
        {
            var patient = GetPatients().SingleOrDefault(p => p.PatientId == id);

            if (patient == null)
                return HttpNotFound();

            return View(patient);
        }

        private IEnumerable<Patient> GetPatients()
        {
            return new List<Patient>
            {
                new Patient {PatientId = 1, PatientName = "Andrew Devine", Address1 = "1 Navestock Gardens", Address2 = "Southend", PostCode = "SS1 3SR"}
            };
        }
    }
}