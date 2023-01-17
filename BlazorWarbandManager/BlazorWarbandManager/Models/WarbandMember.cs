using System.Security.Cryptography;

namespace BlazorWarbandManager.Models;

public class WarbandMember
{
    public string Name { get; set; }
    public string Class { get; set; }
    public List<Ability> Abilities { get; set; }
    public int Health { get; set; }
    public List<Item> Items { get; set; }
}