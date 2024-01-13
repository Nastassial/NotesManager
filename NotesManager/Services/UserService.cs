using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;
using NotesManager.Models.DataTransferObject.TabDtoGroup;
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

    public void DeleteUser(UserIdDto userIdDto)
    {
        _provider.DeleteUser(userIdDto.Id);
    }
}
