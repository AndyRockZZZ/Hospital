using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital.Models;

namespace Hospital.Controllers
{
    public class Patient_OccupancyController : Controller
    {
        // GET: Patient_Occupancy
        public ActionResult Index()
        {
            return View();
        }
    }
}