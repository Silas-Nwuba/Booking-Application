using BookingApplication.Models.Schedule;
using DivineProjectEntity;
using DivineProjectServices.ProjectServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApplication.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly ISchedule _schedule;
        private readonly ITravelSechedule _travelSechedule;
        public ScheduleController(ISchedule schedule, ITravelSechedule travelSechedule)
        {
            _schedule = schedule;
            _travelSechedule = travelSechedule;
        }

        public IActionResult Index()
        {
            ViewBag.Depart = _schedule.Departitems();
            ViewBag.Arival = _schedule.ArivalTime();
            ViewBag.DateOfDeparture = _schedule.DateOfDeparture();
            var ViewModel = new ScheduleViewModel();
            return View(ViewModel);
        }
        //[HttpGet]
        //public IActionResult Create(ScheduleViewModel ScheduleViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
               
        //    }
           
        //}
    }
}
