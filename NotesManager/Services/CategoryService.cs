using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;
using NotesManager.Models.DataTransferObject.CategoryDtoGroup;
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
        User? userDb = _provider.GetUser(categoryDto.UserId);

        if (userDb == null) { return; }

        Category category = new Category()
        {
            Name = categoryDto.Name.Trim(),
            ParentId = categoryDto.ParentId,
            Parent = categoryDto.Parent,
            Users = new List<User> (){ userDb },
        };

        _provider.AddCategory(category);
    }

    public Category? UpdateCategory(CategoryUpdateDto categoryUpdateDto)
    {
        Category? category = _provider.GetCategory(categoryUpdateDto.Id);

        if (category == null) { return null; }

        return _provider.UpdateCategory(category);
    }

    public void DeleteCategory(CategoryDeleteDto categoryDto)
    {
        _provider.DeleteNote(categoryDto.Id);
    }
}
