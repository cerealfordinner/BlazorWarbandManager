using BlazorWarbandManager.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWarbandManager.Pages;

public partial class ViewWarband
{
   [Parameter] public Warband Warband { get; set; }
}