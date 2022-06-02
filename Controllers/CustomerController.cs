using DivineProjectPersistence.Models;
using DivineProjectEntity;
using DivineProjectServices.ProjectServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace DivineProjectPersistence.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer _customer;
        private readonly IWebHostEnvironment _hosting;
        public CustomerController(ICustomer customer , IWebHostEnvironment hosting)
        {
            _customer = customer;
            _hosting = hosting;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var ViewModel = new CustomerIndexViewModels();
            return View(ViewModel);
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerIndexViewModels customerIndexViewModel)
        {
            if (ModelState.IsValid)
            {
                var ViewModel = new Customer
                {
                    Id = customerIndexViewModel.Id,
                    FirstName = customerIndexViewModel.FirstName,
                    LastName = customerIndexViewModel.LastName,
                    FullName = customerIndexViewModel.FullName,
                    Email = customerIndexViewModel.Email,
                    Gender = customerIndexViewModel.Gender,
                    PhoneNumber = customerIndexViewModel.PhoneNumber,
                    NIN = customerIndexViewModel.NIN,
                    NextOfKin = customerIndexViewModel.NextOfKin,
                    NextofKinPhone = customerIndexViewModel.NextofKinPhone,
                    State = customerIndexViewModel.State,

                };
                await _customer.CreateAsync(ViewModel);
                return RedirectToAction("Index", "Booking", new { id = ViewModel.Id });
            }
            return View(nameof(Index));
            //if (customerIndexViewModel.ImageUrl != null && customerIndexViewModel.ImageUrl.Length > 0)
            //{
            //    var UploadDir = @"Image";
            //    var FileName = Path.GetFileNameWithoutExtension(customerIndexViewModel.ImageUrl.FileName);
            //    var FileExtension = Path.GetExtension(customerIndexViewModel.ImageUrl.FileName);
            //    var WebRootPath = _hosting.WebRootPath;
            //    FileName = DateTime.UtcNow.ToString("ddmmyy").ToUpper() + FileName + FileExtension;
            //    var path = Path.Combine(WebRootPath, UploadDir, FileName);
            //    await customerIndexViewModel.ImageUrl.CopyToAsync(new FileStream(path, FileMode.Create));
            //    ViewModel.ImageUrl = "/" + UploadDir + "/" + FileName;
            //  

            //}

        }

    }
}
