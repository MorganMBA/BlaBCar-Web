using System;

namespace BlaBCar.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsMain { get; set; }

        public Trajet Trajet { get; set; }

        public int TrajetId { get; set; }

    }
}