using BookingApplication.Models;
using DivineProjectPersistence;
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
        private readonly ISchedule _schedule;
        private readonly ApplicationDbContext _Context;

        public DestinationController(IDestination destination, ApplicationDbContext context, ISchedule schedule)
        {
            _destination = destination;
            _Context = context;
            _schedule = schedule;
        }
        // GET: DestinationController
        public ActionResult Index()
        {
            ViewBag.Depart = _destination.GetAllDeparture();
            ViewBag.Arival = _destination.GetAllArival();
            ViewBag.DateTime = _destination.GetAllDateTime();
            var ViewModel = new DestinationViewModel();
            return View(ViewModel);
        }

        // GET: DestinationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: DestinationController/Create
        [HttpGet]
        public ActionResult Create(int DepartureId,int ArivalToId , int DateofDeparture, int NoOfPassenger)
        {
            if(DepartureId != 0 &&  ArivalToId != 0)
            {
                var ViewModel = _Context.Travellings.Where(c => c.DepartureId == DepartureId && c.ArivalToId == ArivalToId).SingleOrDefault();
                var Model = new DestinationCreateViewModel()
                {
                    DepartureFrom = _Context.Departures.FirstOrDefault(x => x.Id == DepartureId).DepartureFrom,
                    ArivalTo = _Context.Arivals.FirstOrDefault(c => c.Id == ArivalToId).Arival,
                    DateAndTime = _Context.DateAndTimes.FirstOrDefault(c => c.Id == DateofDeparture).Date,
                    Passenager = NoOfPassenger,
                    Time = _Context.DateAndTimes.FirstOrDefault(c => c.Id == DateofDeparture).Time,
                    BusName = _Context.buses.FirstOrDefault(c => c.Id == ViewModel.BusId).BusName,
                    SeatCapacity = _Context.buses.FirstOrDefault(c => c.Id == ViewModel.BusId).SeatCapacity,
                    Price = ViewModel.Price,
                };
                return View(Model);
            }
            return View();
        }
       // POST: DestinationController/Create
       //[HttpPost]
       //[ValidateAntiForgeryToken]
       // public ActionResult Create(IFormCollection collection)
       // {
       //     try
       //     {
       //         return RedirectToAction(nameof(Index));
       //     }
       //     catch
       //     {
       //         return View();
       //     }
       // }
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
