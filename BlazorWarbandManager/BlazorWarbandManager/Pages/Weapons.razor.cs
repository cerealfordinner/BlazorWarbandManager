using BlazorWarbandManager.Models;

namespace BlazorWarbandManager.Pages;

public partial class Weapons
{
        private List<Item>? _items { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _items = await ItemService.GetItemsAsync("https://gist.githubusercontent.com/cerealfordinner/da6e66425581aa8253ea3dca73c5aed5/raw/8594e74ab6d2e5cf0977890e7e713bbb3a2341f7/items.json");
        }
}