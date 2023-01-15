using System.Text.Json;
using BlazorWarbandManager.Models;

namespace BlazorWarbandManager.Services
{
    public class ItemService
    {
        private readonly string _jsonFilePath;
        private List<Item> _items;

        public ItemService(string jsonFilepath)
        {
            _jsonFilePath = jsonFilepath;
        }

        public IEnumerable<Item> GetItems()
        {
            if (_items != null)
            {
                return _items;
            }

            string jsonString = File.ReadAllText(_jsonFilePath);
            _items = JsonSerializer.Deserialize<List<Item>>(jsonString);

            return _items.Count > 0 ? _items : null;
        }
    }
}