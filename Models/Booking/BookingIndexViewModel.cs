using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApplication.Models
{
    public class BookingIndexViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Departure From field is required")]
        [Display(Name = "Departure From")]
        public int BusId { get; set; }
        [Required(ErrorMessage = "Arival To field is required")]
        [Display(Name = "Arival To")]
        public string ArivalTo { get; set; }
        [Required]
        [Display(Name = "Departure From")]
        public string DepartureFrom { get; set; }
        public string DateOfDeparture { get; set; }

        [RegularExpression("@^[0-9]{2}$", ErrorMessage = "Invalid No of Passenger")]
        [Display(Name = "No of Passenger")]
        [MaxLength(5, ErrorMessage = "the max numbers of passenager should be at least 5")]
        public string NoOfPassenager { get; set; }
        [Required]
        [Display(Name ="Departure Date")]
        public DateTime Date { get; set; } = DateTime.Today;
        [Required]
        [Display(Name = "Ticket Type")]
        public string TicketType { get; set; }
        [Required]
        public decimal TranvelPrice { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }

    }
}
