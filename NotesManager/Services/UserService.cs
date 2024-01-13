using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.CommonDtoGroup;
using NotesManager.Models.DataTransferObject.TabDtoGroup;
using NotesManager.Models.DataTransferObject.UserDtoGroup;
using NotesManager.Services.Interfaces;

namespace NotesManager.Services;

public class UserService : IUserService
{
    private readonly IDataProvider _provider;

    public UserService(IDataProvider provider) 
    {
        _provider = provider;
    }

    public void AddUser(UserAddDto userAddDto)
    {
        User user = new User()
        {
            Login = userAddDto.Login,
            Password = userAddDto.Password,
        };

        _provider.AddUser(user);
    }

    public void DeleteUser(EntityIdDto userIdDto)
    {
        _provider.DeleteUser(userIdDto.Id);
    }
}
