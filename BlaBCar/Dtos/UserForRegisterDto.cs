using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlaBCar.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(15,MinimumLength = 6, ErrorMessage = "You must specify password beetween 6 and 15 characters")]
        public string Password { get; set; }
    }
}
