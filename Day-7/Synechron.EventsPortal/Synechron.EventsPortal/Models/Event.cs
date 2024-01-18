using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Synechron.EventsPortal.Models
{
    public class Event
    {
        public int EventId { get; set; }
        [Required(ErrorMessage = "Event Code is a required field!")]
        [MinLength(6,ErrorMessage ="Event Code should not be less than 6 characters!")]
        [MaxLength(6, ErrorMessage = "Event Code should not be more than 6 characters!")]
        public string EventCode { get; set; }
        [Required(ErrorMessage = "Event Name is a required field!")]
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDateDate { get; set; }
        public decimal Fees { get; set; }
        public int TotalSeatsFilled { get; set; }
        public string Logo { get; set; }
    }
}