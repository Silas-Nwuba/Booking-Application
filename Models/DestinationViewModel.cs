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
        public int DepartureId { get; set; }
        public int ArivalToId { get; set; }
        [Required(ErrorMessage = "Arival To field is required")]
        [Display(Name = "Arival To")]
        public string ArivalTo { get; set; }
        [Required]
        [Display(Name = "Departure From")]
        public string DepartureFrom { get; set; }
    }
}
