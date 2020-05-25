using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlaBCar.Models;

namespace BlaBCar.Data
{
    public class BlaBCarContext: DbContext
    {
        public BlaBCarContext(DbContextOptions<BlaBCarContext> options)
            :base(options)
        {
        }

        public DbSet<Trajet> Trajets { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Photo> Photos { get; set; }
    }
}
