﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Hospital.Models;

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
    }
}