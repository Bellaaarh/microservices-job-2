using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace microservices_job_2.Models
{
    public class TaxiBookingContext : DbContext
    {
        public TaxiBookingContext(DbContextOptions<TaxiBookingContext> options)
            : base(options)
        {
        }

        public DbSet<TaxiBooking> TodoItems { get; set; } = null!;
    }
}
