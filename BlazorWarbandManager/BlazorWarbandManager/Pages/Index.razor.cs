using BlazorWarbandManager.Models;
using BlazorWarbandManager.Models.Enums;
using Microsoft.AspNetCore.Components;

namespace BlazorWarbandManager.Pages;

public partial class Index
{
    private Warband _warband = new();
    private List<Warband> _warbands = new();

    [Parameter]
    public List<Warband> Warbands
    {
        get => _warbands;
        set
        {
            _warbands = value;
            UpdateWarbandInLocalStorage();
        }
    }

    private async Task UpdateWarbandInLocalStorage()
    {
        await localStorage.SetItemAsync("warbands", _warbands);
    }

    private async Task HandleWarbandCreated()
    {
        _warband.DateCreated = DateTime.Today;
        _warbands.Add(_warband);
        Warbands = _warbands;
    }

    public void DeleteWarband(Warband warband)
    {
        _warbands.Remove(warband);
        Warbands = _warbands;
    }

    protected override async Task OnInitializedAsync()
    {
        var localWarbands = await localStorage.GetItemAsync<List<Warband>>("warbands");
        if (localWarbands?.Count > 0)
            _warbands = localWarbands;
    }
}