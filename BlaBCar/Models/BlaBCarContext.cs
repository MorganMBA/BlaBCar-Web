using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaBCar.Models
{
    public class BlaBCarContext: DbContext
    {
        public BlaBCarContext(DbContextOptions<BlaBCarContext> options)
            :base(options)
        {
        }

        public DbSet<Trajet> Trajets { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
