using Microsoft.AspNetCore.Mvc;
using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;
using NotesManager.Services.Interfaces;

namespace NotesManager.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ILogger<CategoriesController> _logger;

        private readonly ICategoryService _categoryService;

        public CategoriesController(ILogger<CategoriesController> logger, ICategoryService service)
        {
            _logger = logger;
            _categoryService = service;
        }

        [HttpPost]
        public IActionResult GetCategoriesList([FromBody] UserIdDto userIdDto)
        {
            CategoryListDto? categoriesList = _categoryService.GetCategoriesList(userIdDto);

            if (categoriesList == null) { return BadRequest(string.Empty); }

            return Ok(categoriesList);
        }

        [HttpPost]
        public IActionResult AddCategory([FromBody] CategoryAddDto categoryDto)
        {
            _categoryService.AddCategory(categoryDto);

            return Ok(categoryDto);
        }

        [HttpPost]
        public IActionResult DeleteCategory([FromBody] CategoryChangeDto categoryChangeDto)
        {
            _categoryService.DeleteCategory(categoryChangeDto);

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateCategory([FromBody] CategoryChangeDto categoryChangeDto)
        {
            Category? category = _categoryService.UpdateCategory(categoryChangeDto);

            if (category == null) { return BadRequest(string.Empty); }

            return Ok(category);
        }
    }
}
