using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlaBCar.Data;
using BlaBCar.Dtos;
using BlaBCar.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlaBCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _repo;

        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        // Post: api/Register/
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userDto)
        {
            userDto.Username = userDto.Username.ToLower();

            if (await _repo.UserExists(userDto.Username))
                BadRequest("Username already exists");

            var userToCreate = new User
            {
                Username = userDto.Username
            };

            var createdUser = await _repo.Register(userToCreate, userDto.Password);

            return StatusCode(201);
        }

    }
}