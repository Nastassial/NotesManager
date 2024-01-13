using NotesManager.Models.DataTransferObject;

namespace NotesManager.Services.Interfaces;

public interface IUserService
{
    public void AddUser(UserAddDto userAddDto);

    public void DeleteUser(UserIdDto userIdDto);
}
