using Microsoft.AspNetCore.Mvc;
using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;
using NotesManager.Models.DataTransferObject.CategoryDtoGroup;
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

            if (categoriesList == null) 
            { 
                return BadRequest(string.Empty); 
            }

            return Ok(categoriesList);
        }

        [HttpPost]
        public IActionResult AddCategory([FromBody] CategoryAddDto categoryAddDto)
        {
            _categoryService.AddCategory(categoryAddDto);

            return Ok(categoryAddDto);
        }

        [HttpPost]
        public IActionResult DeleteCategory([FromBody] CategoryDeleteDto categoryDeleteDto)
        {
            _categoryService.DeleteCategory(categoryDeleteDto);

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateCategory([FromBody] CategoryUpdateDto categoryUpdateDto)
        {
            Category? category = _categoryService.UpdateCategory(categoryUpdateDto);

            if (category == null) 
            { 
                return BadRequest(string.Empty); 
            }

            return Ok(category);
        }
    }
}
