using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleCoreAPI.Data.Services;
using SampleCoreAPI.Data.ViewModels;
using SampleCoreAPI.Models;

namespace SampleCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("get-all-user")]
        public async Task<IActionResult> GetAllUser()
        {
            var allUser = await _userService.GetUsers();
            return Ok(allUser);
        }

        [HttpGet("get-user-by-id/{id}")]
        public async Task<IActionResult> GetUserById([FromRoute]int id)
        {
            UserAccount user = await _userService.GetUserById(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddNewUser([FromBody]UserVM userVM)
        {
            var id = await _userService.AddUser(userVM);
            return CreatedAtAction(nameof(GetUserById),new {id = id, controller = "users" }, id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNewUser([FromBody] UserVM userVM, [FromRoute]int id)
        {
            await _userService.UpdateUser(id, userVM);
            return Ok();
        }
    }
}
