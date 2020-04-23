using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaBCar.Models
{
    public class Reservation
    {
        public long Id { get; set; }
        public string NomBooker { get; set; }
        public string TelephoneBooker { get; set; }
        public virtual ICollection<Trajet> Trajets {get; set;}
    }
}
