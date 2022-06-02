using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApplication.Models.Booking
{
    public class BookingDetailsViewModel
    {
        public int Id { get; set; }
        public string DepartureFrom { get; set; }
        public string ArivalTo { get; set; }
        public string NoOfPassenager { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public decimal TranvelPrice { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
