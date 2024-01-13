using Microsoft.AspNetCore.Mvc;
using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.CommonDtoGroup;
using NotesManager.Models.DataTransferObject.TabDtoGroup;
using NotesManager.Services.Interfaces;

namespace NotesManager.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TabsController : ControllerBase
    {
        private readonly ILogger<TabsController> _logger;

        private readonly ITabService _tabService;

        public TabsController(ILogger<TabsController> logger, ITabService service)
        {
            _logger = logger;
            _tabService = service;
        }

        [HttpPost]
        public IActionResult AddTab([FromBody] TabDto tabDto)
        {
            _tabService.AddTab(tabDto);

            return Ok(tabDto);
        }

        [HttpPost]
        public IActionResult GetTab([FromBody] EntityIdDto tabIdDto)
        {
            TabDto? tab = _tabService.GetTab(tabIdDto);

            if (tab == null) { return BadRequest(string.Empty); }

            return Ok(tab);
        }

        [HttpPost]
        public IActionResult DeleteTab([FromBody] EntityIdDto tabIdDto)
        {
            _tabService.DeleteTab(tabIdDto);

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateTab([FromBody] TabUpdateDto tabUpdateDto)
        {
            Tab? tab = _tabService.UpdateTab(tabUpdateDto);

            if (tab == null) { return BadRequest(string.Empty); }

            return Ok(tab);
        }
    }
}
