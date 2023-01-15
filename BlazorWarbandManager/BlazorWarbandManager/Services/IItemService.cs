using BlazorWarbandManager.Models;

namespace BlazorWarbandManager.Services;

public interface IItemService
{
    Task<List<Item>?> GetItemsAsync(string uri);
}