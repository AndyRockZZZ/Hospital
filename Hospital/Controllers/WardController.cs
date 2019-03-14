using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital.Models;

namespace Hospital.Controllers
{
    public class WardController : Controller
    {
        // GET: Ward
        public ActionResult Index()
        {
            var wards = GetWards();

            return View(wards);
        }

        private IEnumerable<Ward> GetWards()
        {
            return new List<Ward>
            {
                new Ward {WardId = 1, WardName = "Anaesthetic"},
                new Ward {WardId = 2, WardName = "Pharamacy"}
            };
        }
    }
}