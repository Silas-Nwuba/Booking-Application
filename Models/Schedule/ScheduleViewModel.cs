using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApplication.Models.Schedule
{
    public class ScheduleViewModel
    {
        public int Id { get; set; }
        public int TravelScheduleId { get; set; }
        [Required(ErrorMessage = "Arival To field is required")]
        [Display(Name = "Arival To")]
        public string ArivalTo { get; set; }
        [Required]
        [Display(Name = "Departure From")]
        public string DepartureFrom { get; set; }
        public string DateOfDeparture { get; set; }
        [Display(Name = "No of Passenger")]
        public int NoPassenger { get; set; }
    }
}
