using BlazorWarbandManager.Models;
using Microsoft.AspNetCore.Components;
namespace BlazorWarbandManager.Pages;

public partial class Index
{
    [Inject] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    [Inject] private NavigationManager UriHealper { get; set; }
    private Warband _warband = new();
    private List<Warband> _warbands = new();
    [Parameter] public List<Warband> Warbands
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

    private Task HandleWarbandCreated()
    {
        _warband.DateCreated = DateTime.Today;
        _warband.Id = Guid.NewGuid();
        _warbands.Add(_warband);
        Warbands = _warbands;
        _warband = new Warband();
        return Task.CompletedTask;
    }

    public void DeleteWarband(Warband warband)
    {
        _warbands.Remove(warband);
        Warbands = _warbands;
    }

    private void ViewWarband(Warband warband)
    {
    }

    protected override async Task OnInitializedAsync()
    {
        var localWarbands = await localStorage.GetItemAsync<List<Warband>>("warbands");
        if (localWarbands?.Count > 0)
            _warbands = localWarbands;
    }
}