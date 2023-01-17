using System.ComponentModel;

namespace BlazorWarbandManager.Models.Enums;

public class WarbandManagerEnums
{
    public enum GameSystemsEnum
    {
        [Description("None")]
        None,
        [Description("The Last War")]
        TheLastWar,
        [Description("Space Station Zero")]
        SpaceStationZero,
        [Description("Frostgrave")]
        Frostgrave,
        [Description("Stargrave")]
        Stargrave
    }
}