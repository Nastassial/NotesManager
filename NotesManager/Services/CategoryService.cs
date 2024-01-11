using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;
using NotesManager.Services.Interfaces;

namespace NotesManager.Services;

public class CategoryService : ICategoryService
{
    private readonly IDataProvider _provider;

    public CategoryService(IDataProvider provider) 
    {
        _provider = provider;
    }

    public CategoryListDto? GetCategoriesList(UserIdDto userIdDto)
    {
        List<Category> userCategoryList = _provider.GetUserCategoryList(userIdDto.Id);

        if (userCategoryList == null) { return null; }

        return new CategoryListDto
        {
            CategoriesList = userCategoryList,
        };
    }

    public void AddCategory(CategoryAddDto categoryDto)
    {
        Category category = new Category()
        {
            Name = categoryDto.Name,
        };

        _provider.AddCategory(category);
    }

    public Category? UpdateCategory(CategoryChangeDto categoryDto)
    {
        Category? category = _provider.GetCategory(categoryDto.Id);

        if (category == null) { return null; }

        return _provider.UpdateCategory(category);
    }

    public void DeleteCategory(CategoryChangeDto categoryDto)
    {
        _provider.DeleteNote(categoryDto.Id);
    }
}
