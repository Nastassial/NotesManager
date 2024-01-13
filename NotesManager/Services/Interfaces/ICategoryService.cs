using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;
using NotesManager.Models.DataTransferObject.CategoryDtoGroup;
using NotesManager.Models.DataTransferObject.CommonDtoGroup;

namespace NotesManager.Services.Interfaces;

public interface ICategoryService
{
    public CategoryListDto? GetCategoriesList(EntityIdDto userIdDto);

    public void AddCategory(CategoryAddDto categoryDto);

    public Category? UpdateCategory(CategoryUpdateDto categoryDto);

    public void DeleteCategory(EntityIdDto categoryDto);
}
