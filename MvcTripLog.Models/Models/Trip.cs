using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace MvcTripLog.Models
{
    public class Trip
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Travel Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime TravelDate { get; set; }
        public string Region { get; set; }
        public decimal Price { get; set; }

        [Display(Name = "Trip Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string TripDate { get; set; }
        public string Attraction { get; set; }
    }
    public class TripDBContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }
    }
}