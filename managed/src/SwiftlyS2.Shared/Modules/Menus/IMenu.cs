using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.Players;

namespace SwiftlyS2.Shared.Menus;

public enum MenuType
{
    CenterMenu,
};

public interface IMenu
{
    /// <summary>
    /// The title of the menu.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// The maximum length of the title. (default: 32)
    /// </summary>
    public int MaxTitleLength { get; set; }
    /// <summary>
    /// The options in the menu. Not supposed to be modified manually.
    /// </summary>
    public List<IMenuOption> Options { get; set; }
    /// <summary>
    /// Whether to freeze the player while the menu is open.
    /// </summary>
    public bool? FreezePlayer { get; set; }
    /// <summary>
    /// Whether the menu has sound effects.
    /// </summary>
    public bool HasSound { get; set; }
    /// <summary>
    /// The parent menu if this is a submenu.
    /// </summary>
    public IMenu? ParentMenu { get; set; }
    /// <summary>
    /// Whether the menu can be exited.
    /// </summary>
    public bool CanExit { get; set; }
    /// <summary>
    /// The kind of the menu.
    /// </summary>
    public MenuType Kind { get; set; }
    /// <summary>
    /// The color of the menu.
    /// </summary>
    public Color Color { get; set; }
    /// <summary>
    /// The text to render to the user.
    /// </summary>
    public string? RenderText { get; }
    /// <summary>
    /// The current item selected.
    /// </summary>
    public int CurrentIndex { get; set; }

    /// <summary>
    /// Add an option to the menu.
    /// </summary>
    /// <param name="display">Text to display</param>
    /// <param name="onChoice">Use Callback</param>
    /// <param name="defaultDisabled">Make it disabled by default</param>
    /// <returns>Menu Option</returns>
    public ref IMenuOption AddOption(string display, Action<IPlayer, IMenuOption, IMenu>? onChoice, bool defaultDisabled = false);
    /// <summary>
    /// Add a boolean option to the menu.
    /// </summary>
    /// <param name="display">Text to display</param>
    /// <param name="defaultValue">Default value</param>
    /// <param name="onChoice">Use Callback</param>
    /// <param name="defaultDisabled">Make it disabled by default</param>
    /// <returns>Menu Option</returns>
    public ref IMenuOption AddBoolOption(string display, bool defaultValue, Action<IPlayer, IMenuOption, IMenu>? onChoice, bool defaultDisabled = false);
    /// <summary>
    /// Add an input option to the menu.
    /// </summary>
    /// <param name="display">Text to display</param>
    /// <param name="placeholder">Placeholder text</param>
    /// <param name="inputRequestMessage">Input request message</param>
    /// <param name="onInput">Use Callback</param>
    /// <param name="defaultDisabled">Make it disabled by default</param>
    /// <returns>Menu Option</returns>
    public ref IMenuOption AddInputOption(string display, string placeholder, string? inputRequestMessage, Action<IPlayer, IMenuOption, IMenu, string>? onInput, bool defaultDisabled = false);
    /// <summary>
    /// Add a slider option to the menu.
    /// </summary>
    /// <param name="display">Text to display</param>
    /// <param name="values">List of values</param>
    /// <param name="defaultValue">Default value</param>
    /// <param name="displayItems">Number of items to display</param>
    /// <param name="onSlide">Use Callback</param>
    /// <param name="defaultDisabled">Make it disabled by default</param>
    /// <returns>Menu Option</returns>
    public ref IMenuOption AddSliderOption(string display, List<object> values, object? defaultValue, int displayItems, Action<IPlayer, IMenuOption, IMenu, int, object>? onSlide, bool defaultDisabled = false);

    /// <summary>
    /// Changes the current position by a certain count.
    /// </summary>
    /// <param name="count">The amount of advancements to make in front or in back</param>
    public void ChangePosition(int count);
}