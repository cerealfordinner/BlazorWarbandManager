using BlazorWarbandManager.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWarbandManager.Pages;

public partial class ViewWarband
{
    [Inject] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    [Parameter] public Guid WarbandId { get; set; }
    private Warband? Warband { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        List<Warband>? localWarbands = await localStorage.GetItemAsync<List<Warband>>("warbands");
        // Warband = localWarbands.FirstOrDefault(x => x.Id == WarbandId );
    }
}