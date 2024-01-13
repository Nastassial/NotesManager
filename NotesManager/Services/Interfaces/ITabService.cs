using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.TabDtoGroup;

namespace NotesManager.Services.Interfaces;

public interface ITabService
{
    public void AddTab(TabDto tabDto);

    public TabDto? GetTab(TabIdDto tabIdDto);

    public Tab? UpdateTab(TabUpdateDto tabUpdateDto);

    public void DeleteTab(TabIdDto tabIdDto);
}
