using Microsoft.AspNetCore.Mvc;
using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.CommonDtoGroup;
using NotesManager.Models.DataTransferObject.TabDtoGroup;
using NotesManager.Models.DataTransferObject.UserDtoGroup;
using NotesManager.Services.Interfaces;

namespace NotesManager.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        private readonly IUserService _userService;

        public UsersController(ILogger<UsersController> logger, IUserService service)
        {
            _logger = logger;
            _userService = service;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserAddDto userAddDto)
        {
            _userService.AddUser(userAddDto);

            return Ok(userAddDto);
        }

        [HttpPost]
        public IActionResult DeleteUser([FromBody] EntityIdDto userIdDto)
        {
            _userService.DeleteUser(userIdDto);

            return Ok();
        }
    }
}
