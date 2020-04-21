using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaBCar.Models
{
    public class Trajet
    {
        public long Id { get; set; }
        public string NomChauffeur { get; set; }
        public string TelephoneChauffeur { get; set; }
        public uint AgeChauffeur { get; set; }
        public string LieuDepart { get; set; }
        public string LieuArrive { get; set; }
        public DateTime DateDepart { get; set; }
        public uint DureeTrajet { get; set; }
        public uint NbrePlaceDispo { get; set; }
        public uint NbreReservation { get; set; }
        public bool Bagage { get; set; }
        public bool Fumeur { get; set; }
        public bool Handicape { get; set; }
        public bool Animaux { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
