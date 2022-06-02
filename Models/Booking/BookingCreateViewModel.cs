using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApplication.Models.Booking
{
    public class BookingCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Departure From field is required")]
        [Display(Name = "Departure From")]
        public string DepartureFrom { get; set; }
        [Required(ErrorMessage = "Arival To field is required")]
        [Display(Name = "Arival To")]
        public string ArivalTo { get; set; }
        public string NoOfPassenager { get; set; }
        [Required]
        [Display(Name = "Departure Date")]
        public DateTime Date { get; set; } = DateTime.Today;
       
        [Required]
        public decimal TranvelPrice { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }

    }
}
