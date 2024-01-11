using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;

namespace NotesManager.Services.Interfaces;

public interface ICategoryService
{
    public CategoryListDto? GetCategoriesList(UserIdDto userIdDto);

    public void AddCategory(CategoryAddDto categoryDto);

    public Category? UpdateCategory(CategoryChangeDto categoryDto);

    public void DeleteCategory(CategoryChangeDto categoryDto);
}
