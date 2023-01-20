using BlazorWarbandManager.Models.Enums;

namespace BlazorWarbandManager.Models;

public class Warband
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string GameSystem { get; set; }
    public DateTime DateCreated { get; set; }
    public List<WarbandMember>? WarbandMembers{ get; set; }
    public string? Notes { get; set; }
}
