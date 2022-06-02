//using BookingApplication.Models;
//using BookingApplication.Models.Booking;
//using DivineProjectEntity;
//using DivineProjectServices.ProjectServices;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace BookingApplication.Controllers
//{
//    public class BookingController : Controller
//    {
//        private readonly IBookingRecord _Booking;
//        private string Arival;
//        private string depart;
//        private decimal TravelPrice;
//        public BookingController(IBookingRecord bookingRecord)
//        {
//            _Booking = bookingRecord;
//        }
//        public IActionResult Index()
//        {
//            var Viewmodel = new BookingIndexViewModel();

//            return View(Viewmodel);
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Create()
//        {
//            var ViewModel = new BookingCreateViewModel()
//            {

//            };
//            return View(ViewModel);
//        }
//    }
//}