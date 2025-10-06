using SwiftlyS2.Shared.Services;
using System.Drawing;

namespace SwiftlyS2.Shared.Menus;

public enum MenuType
{
    CenterMenu,
};

public interface IMenu
{
    public string Title { get; set; }
    public int MaxTitleLength { get; set; }
    public int MaxOptionLength { get; set; }
    public List<IMenuOption> Options { get; set; }
    public List<IMenuOption>? PreviousOptions { get; set; }
    public bool? FreezePlayer { get; set; }
    public bool HasSound { get; set; }
    public IMenu? ParentMenu { get; set; }
    public bool CanExit { get; set; }
    public MenuType Kind { get; set; }
    public Color Color { get; set; }

    public ref IMenuOption AddOption(string display, Action<IPlayer, IMenuOption, IMenu>? onChoice, bool defaultDisabled = false);
    public ref IMenuOption AddBoolOption(string display, bool defaultValue, Action<IPlayer, IMenuOption, IMenu>? onChoice, bool defaultDisabled = false);
    public ref IMenuOption AddInputOption(string display, string placeholder, string? inputRequestMessage, Action<IPlayer, IMenuOption, IMenu, string>? onInput, bool defaultDisabled = false);
    public ref IMenuOption AddSliderOption(string display, List<object> values, object? defaultValue, int displayItems, Action<IPlayer, IMenuOption, IMenu, int, object>? onSlide, bool defaultDisabled = false);
}