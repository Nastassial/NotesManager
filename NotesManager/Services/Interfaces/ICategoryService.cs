using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;
using NotesManager.Models.DataTransferObject.CategoryDtoGroup;

namespace NotesManager.Services.Interfaces;

public interface ICategoryService
{
    public CategoryListDto? GetCategoriesList(UserIdDto userIdDto);

    public void AddCategory(CategoryAddDto categoryDto);

    public Category? UpdateCategory(CategoryUpdateDto categoryDto);

    public void DeleteCategory(CategoryDeleteDto categoryDto);
}
