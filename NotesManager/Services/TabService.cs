using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.TabDtoGroup;
using NotesManager.Services.Interfaces;

namespace NotesManager.Services;

public class TabService : ITabService
{
    private readonly IDataProvider _provider;

    public TabService(IDataProvider provider) 
    {
        _provider = provider;
    }

    public void AddTab(TabDto tabDto)
    {
        Tab tab = new Tab()
        {
            Title = tabDto.Title,
            Description = tabDto.Description,
            Url = tabDto.Url,
            //CategoryId = tabDto.CategoryId,
            UserId = tabDto.UserId,
        };

        _provider.AddTab(tab);
    }

    public TabDto? GetTab(TabIdDto tabIdDto)
    {
        Tab? tab = _provider.GetTab(tabIdDto.Id);

        if (tab == null) { return null; }

        return new TabDto
        {
            Title = tab.Title,
            Description = tab.Description,
            //CategoryId = tab.CategoryId,
            UserId = tab.UserId,
            Url = tab.Url,
        };
    }

    public Tab? UpdateTab(TabUpdateDto tabUpdateDto)
    {
        Tab? tab = _provider.GetTab(tabUpdateDto.Id);

        if (tab == null) { return null; }

        tab.Title = tabUpdateDto.Title;
        tab.Description = tabUpdateDto.Description;
        tab.Url = tabUpdateDto.Url;

        return _provider.UpdateTab(tab);
    }

    public void DeleteTab(TabIdDto tabIdDto)
    {
        _provider.DeleteTab(tabIdDto.Id);
    }
}
