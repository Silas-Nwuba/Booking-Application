using BookingApplication.Models;
using DivineProjectServices.ProjectServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApplication.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestination _destination;

        public DestinationController(IDestination destination)
        {
            _destination = destination;
        }

        // GET: DestinationController
        public ActionResult Index()
        {
            ViewBag.Depart = _destination.GetAllDeparture();
            ViewBag.Arival = _destination.GetAllArival();
            var ViewModel = new DestinationViewModel();
            return View(ViewModel);
        }

        // GET: DestinationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DestinationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DestinationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DestinationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DestinationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DestinationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DestinationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
