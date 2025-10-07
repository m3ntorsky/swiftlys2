using SwiftlyS2.Shared.Players;

namespace SwiftlyS2.Shared.Menus;

public enum OptionType
{
    Button,
    Bool,
    Text,
    Input,
    Slider,
}

public interface IMenuOption
{
    public IMenu? Menu { get; set; }
    public string Display { get; set; }
    public Action<IPlayer, IMenuOption, IMenu>? OnChoice { get; set; }
    public Action<IPlayer, IMenuOption, IMenu, string>? OnInput { get; set; }
    public Action<IPlayer, IMenuOption, IMenu, int, object>? OnSlide { get; set; }
    public int Index { get; set; }
    public OptionType Type { get; set; }
    public bool Disabled { get; set; }
    public object? DefaultValue { get; set; }
    public int SliderDisplayItems { get; set; }
    public List<object>? SliderValues { get; set; }
    public object? Value { get; set; }
    public int SelectedIndex { get; }
}