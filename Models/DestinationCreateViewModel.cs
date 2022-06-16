using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApplication.Models
{
    public class DestinationCreateViewModel
    {
        public int Id { get; set; }
      
        [Required(ErrorMessage = "Departure field is required")]
        public int DepartureId { get; set; }
        public int ArivalToId { get; set; }
        [Required(ErrorMessage = "Arival To field is required")]
        [Display(Name = "Arival To")]
        public string ArivalTo { get; set; }
        [Required]
        [Display(Name = "Departure From")]
        public string DepartureFrom { get; set; }
        public string  Seat { get; set; }
        [Display(Name = "Total Price")]
        public decimal Price { get; set; }
        [Display(Name = "Bus Name")]
        public string BusName { get; set; }
        public int SeatCapacity { get; set; }
        public string DateAndTime { get;  set; }
        public string Time { get; set; }
        public int Passenager { get; set; }
    }
}
