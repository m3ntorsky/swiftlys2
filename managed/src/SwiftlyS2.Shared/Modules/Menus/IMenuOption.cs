using SwiftlyS2.Shared.Players;

namespace SwiftlyS2.Shared.Menus;

public enum OptionType
{
    Button,
    Bool,
    Input,
    Slider,
}

public interface IMenuOption
{
    /// <summary>
    /// The menu this option belongs to.
    /// </summary>
    public IMenu? Menu { get; set; }
    /// <summary>
    /// The text to display for this option.
    /// </summary>
    public string Display { get; set; }
    /// <summary>
    /// The callback to invoke when this option is selected.
    /// </summary>
    public Action<IPlayer, IMenuOption, IMenu>? OnChoice { get; set; }
    /// <summary>
    /// The callback to invoke when input is received for this option (only for Input type).
    /// </summary>
    public int Index { get; set; }
    /// <summary>
    /// The type of this option (Button, Bool, Input, Slider).
    /// </summary>
    public OptionType Type { get; set; }
    /// <summary>
    /// Whether this option is disabled.
    /// </summary>
    public bool Disabled { get; set; }
    /// <summary>
    /// The default value for this option (only for Bool, Input, Slider types).
    /// </summary>
    public object? DefaultValue { get; set; }
    /// <summary>
    /// The number of items to display on screen for slider
    /// </summary>
    public int SliderDisplayItems { get; set; }
    /// <summary>
    /// The possible values for this option (only for Slider type).
    /// </summary>
    public List<object>? SliderValues { get; set; }
    /// <summary>
    /// The current value of this option (only for Bool, Input, Slider types).
    /// </summary>
    public object? Value { get; set; }
    /// <summary>
    /// The currently selected index for this option (only for Slider type).
    /// </summary>
    public int SelectedIndex { get; }
}