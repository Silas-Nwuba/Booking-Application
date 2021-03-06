using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApplication.Models
{
    public class DestinationViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Departure field is required")]
        public int DepartureId { get; set; }
        [Required(ErrorMessage = "Arival To field is required")]
        public int ArivalToId { get; set; }
        
        [Display(Name = "Arival To")]
        public string ArivalTo { get; set; }
      
        [Display(Name = "Departure From")]
        public string DepartureFrom { get; set; }
        [Display(Name = "Date of Departure")]
        public string DateofDeparture { get; set; }
        public int NoOfPassenger { get; set; } = 1;

        public decimal Price { get; set; }
        [Display(Name = "Bus Name")]
        public string BusName { get; set; }
        public int SeatCapacity { get; set; }
    }
}
