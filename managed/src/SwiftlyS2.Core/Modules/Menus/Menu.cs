using SwiftlyS2.Shared.Menus;
using SwiftlyS2.Shared.Players;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Core.Menus;

internal class Menu : IMenu
{
    public string Title { get; set; } = "";
    public int MaxTitleLength { get; set; } = 32;
    public int MaxOptionLength { get; set; } = 32;
    public List<IMenuOption> Options { get; set; } = new();
    public List<IMenuOption>? PreviousOptions { get; set; } = new();
    public bool? FreezePlayer { get; set; } = null;
    public bool HasSound { get; set; } = true;
    public IMenu? ParentMenu { get; set; } = null;
    public bool CanExit { get; set; } = true;
    public MenuType Kind { get; set; } = MenuType.CenterMenu;
    public Color Color { get; set; }
    public IMenuManager? Manager { get; set; } = null;
    public string? RenderText { get; private set; } = null;

    public ref IMenuOption AddBoolOption(string display, bool defaultValue, Action<IPlayer, IMenuOption, IMenu>? onChoice, bool defaultDisabled = false)
    {
        Options.Add(new MenuOption
        {
            Menu = this,
            Display = $"{(defaultValue ? "[<font color='green'>✔</font>]" : "[<font color='red'>❌</font>]")} {display}",
            Type = OptionType.Bool,
            Disabled = defaultDisabled,
            DefaultValue = defaultValue,
            Index = Options.Count,
            OnChoice = defaultDisabled ? null : (IPlayer player, IMenuOption option, IMenu menu) =>
            {
                if (option.Type == OptionType.Bool)
                {
                    bool disabled = option.Value is false;
                    option.Display = $"{(defaultValue ? "[<font color='green'>✔</font>]" : "[<font color='red'>❌</font>]")} {display}";
                    if (onChoice != null) onChoice!(player, option, menu);
                }
            },
        });

        return ref CollectionsMarshal.AsSpan(Options)[^1];
    }

    public ref IMenuOption AddInputOption(string display, string placeholder, string? inputRequestMessage, Action<IPlayer, IMenuOption, IMenu, string>? onInput, bool defaultDisabled = false)
    {
        Options.Add(new MenuOption
        {
            Menu = this,
            Display = defaultDisabled ? $"<font color='grey'>{display}: {placeholder}</font>" : $"{display}: <font color='grey'>{placeholder}</font>",
            Type = OptionType.Input,
            Disabled = defaultDisabled,
            Index = Options.Count,
            OnChoice = defaultDisabled ? null : (IPlayer player, IMenuOption option, IMenu menu) =>
            {
                if (option.Type == OptionType.Input && onInput != null && Manager != null)
                {
                    Manager.SetInputState(player, (p, o, m, s) =>
                    {
                        o.Display = $"{display}: {s}";
                        onInput!(p, o, m, s);
                    });
                }
            },
        });

        return ref CollectionsMarshal.AsSpan(Options)[^1];
    }

    public ref IMenuOption AddOption(string display, Action<IPlayer, IMenuOption, IMenu>? onChoice, bool defaultDisabled = false)
    {
        Options.Add(new MenuOption
        {
            Menu = this,
            Display = defaultDisabled ? $"<font color='grey'>{display}</font>" : display,
            Type = OptionType.Button,
            Disabled = defaultDisabled,
            Index = Options.Count,
            OnChoice = defaultDisabled ? null : onChoice,
        });

        return ref CollectionsMarshal.AsSpan(Options)[^1];
    }

    public ref IMenuOption AddSliderOption(string display, List<object> values, object? defaultValue, int displayItems, Action<IPlayer, IMenuOption, IMenu, int, object>? onSlide, bool defaultDisabled = false)
    {
        if (values == null || values.Count == 0)
        {
            Options.Add(new MenuOption
            {
                Menu = this,
                Display = $"<font color='#afafaf'>{display}: Empty</font>",
                Type = OptionType.Slider,
                Disabled = true,
                Index = Options.Count,
                SliderValues = new List<object>(),
                DefaultValue = null,
                SliderDisplayItems = 0,
                OnSlide = null,
            });
        }
        else
        {
            if (defaultValue == null && values.Count > 0)
            {
                defaultValue = values[0];
            }

            displayItems = Math.Max(1, Math.Min(displayItems, values.Count));

            Options.Add(new MenuOption
            {
                Menu = this,
                Display = defaultDisabled ? $"<font color='grey'>{display}: {defaultValue}</font>" : $"{display}: {defaultValue}",
                Type = OptionType.Slider,
                Disabled = defaultDisabled,
                Index = Options.Count,
                SliderValues = values,
                DefaultValue = defaultValue,
                SliderDisplayItems = displayItems,
                OnChoice = defaultDisabled ? null : (IPlayer player, IMenuOption option, IMenu menu) =>
                {
                    if (option.Type == OptionType.Slider && option.SliderValues != null)
                    {
                        int idx = option.SelectedIndex;
                        if (onSlide != null) onSlide!(player, option, menu, idx, option.SliderValues[idx]);
                    }
                },
            });
        }

        return ref CollectionsMarshal.AsSpan(Options)[^1];
    }
}