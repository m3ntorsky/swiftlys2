using SwiftlyS2.Shared.Menus;
using SwiftlyS2.Shared.Players;

namespace SwiftlyS2.Core.Menus;

internal class MenuOption : IMenuOption
{
    public IMenu? Menu { get; set; }
    public string Display { get; set; } = "";
    public Action<IPlayer, IMenuOption, IMenu>? OnChoice { get; set; } = (_,_,_) => { };
    public Action<IPlayer, IMenuOption, IMenu, string>? OnInput { get; set; } = (_,_,_,_) => { };
    public Action<IPlayer, IMenuOption, IMenu, int, object>? OnSlide { get; set; } = (_,_,_,_,_) => { };
    public int Index { get; set; }
    public OptionType Type { get; set; }
    public bool Disabled { get; set; }
    public object? DefaultValue { get; set; }
    public int SliderDisplayItems { get; set; }
    public List<object>? SliderValues { get; set; }
    public object? Value
    {
        get => DefaultValue;
        set => DefaultValue = value;
    }

    public int SelectedIndex
    {
        get {
            if(SliderValues == null || DefaultValue == null) return 0;
            // fuck you mean `.Equals` returns a `bool?`
            int idx = SliderValues.FindIndex(x => x?.Equals(DefaultValue) == true);
            return idx >= 0 ? idx : 0;
        }
    }
};