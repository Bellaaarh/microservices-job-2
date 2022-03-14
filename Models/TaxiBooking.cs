using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace microservices_job_2.Models
{
    public class TaxiBooking
    {
        public long Id { get; set; }
        public int Date { get; set; }
        public int Time { get; set; }

        public string? PickupPoint { get; set; }
        public string? Destination { get; set; }
        public long Current_Location_Latitude { get; set; }
        public long Current_Location_Longitude { get; set; }
    }
}
