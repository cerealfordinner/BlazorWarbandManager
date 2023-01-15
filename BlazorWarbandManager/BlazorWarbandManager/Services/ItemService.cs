using System.Net.Http.Json;
using System.Text.Json;
using BlazorWarbandManager.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorWarbandManager.Services
{
    public class ItemService : IItemService
    {
        private readonly HttpClient httpClient;

        public ItemService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Item>?> GetItemsAsync(string uri)
        {
            var jsonString =  await httpClient.GetStringAsync(uri);
            return JsonSerializer.Deserialize<List<Item>>(jsonString);
        }
    }
}