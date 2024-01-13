using NotesManager.Models.DataTransferObject.CommonDtoGroup;
using NotesManager.Models.DataTransferObject.UserDtoGroup;

namespace NotesManager.Services.Interfaces;

public interface IUserService
{
    public void AddUser(UserAddDto userAddDto);

    public void DeleteUser(EntityIdDto userIdDto);
}
