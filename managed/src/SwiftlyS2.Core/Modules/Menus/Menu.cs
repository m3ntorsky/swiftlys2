using SwiftlyS2.Shared.Menus;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.Players;
using System.Runtime.InteropServices;
using System.Text;

namespace SwiftlyS2.Core.Menus;

internal class Menu : IMenu
{
    public string Title { get; set; } = "";
    public int MaxTitleLength { get; set; } = 32;
    public List<IMenuOption> Options { get; set; } = new();
    public bool? FreezePlayer { get; set; } = null;
    public bool HasSound { get; set; } = true;
    public IMenu? ParentMenu { get; set; } = null;
    public bool CanExit { get; set; } = true;
    public MenuType Kind { get; set; } = MenuType.CenterMenu;
    public Color Color { get; set; } = new(255, 255, 255);
    public IMenuManager? Manager { get; set; } = null;
    public string? RenderText { get; private set; } = null;
    public int CurrentIndex { get; set; } = 0;
    public void Rerender()
    {
        if (Kind != MenuType.CenterMenu) return;

        var colHex = $"#{Color.R:X2}{Color.G:X2}{Color.B:X2}";
        if (Title.Length > MaxTitleLength) Title = Title[..MaxTitleLength];

        var builder = new StringBuilder();
        builder.Append($"<b><font color='{colHex}' class='fontSize-m'>{Title}</font></b> <font class='fontSize-sm'>[{CurrentIndex + 1}/{Options.Count}]</font><br>");

        var halfPage = Manager!.Settings.ItemsPerPage / 2;
        var virtualItems = Options.SelectMany((option, i) =>
        {
            var items = new List<(int, bool, IMenuOption)> { (i, false, option) };
            if (option.Type == OptionType.Slider && option.SliderValues?.Count > 0)
            {
                items.Add((i, true, option));
            }
            return items;
        }).ToList();
        var currentVirtualIdx = virtualItems.FindIndex(x => x.Item1 == CurrentIndex && !x.Item2);
        currentVirtualIdx = currentVirtualIdx == -1 ? CurrentIndex : currentVirtualIdx;
        var startIdx = currentVirtualIdx - halfPage;
        var displayCount = Math.Min(Manager.Settings.ItemsPerPage, virtualItems.Count);

        for (int j = 0; j < displayCount; j++)
        {
            var virtualIdx = ((startIdx + j) % virtualItems.Count + virtualItems.Count) % virtualItems.Count;
            var (originalIdx, isSliderValue, option) = virtualItems[virtualIdx];

            builder.Append(isSliderValue ? RenderSliderValues(option, originalIdx == CurrentIndex, colHex) : RenderMenuItem(option, originalIdx, colHex));
            builder.Append("<br>");
        }

        if (Manager?.Settings.InputMode == "button")
        {
            builder.Append($"<font class='fontSize-s'>Move: [{Manager.Settings.ButtonsScroll.ToUpper()}] | Use: [{Manager.Settings.ButtonsUse.ToUpper()}] | Back: [{Manager.Settings.ButtonsExit.ToUpper()}]</font>");
        }
        else if (Manager?.Settings.InputMode == "wasd")
        {
            builder.Append($"<font class='fontSize-s'>Move: [W/S] | Use: [D] | Back: [A]</font>");
        }

        RenderText = builder.ToString();

        var player = Manager?.GetPlayerFromMenu(this);
        if (player != null && Manager != null) Manager.RenderForPlayer(player);
    }

    private string RenderSliderValues(IMenuOption option, bool isCurrent, string colHex)
    {
        if (option.SliderValues == null || option.SliderValues.Count == 0) return "Empty";

        var displayItems = Math.Min(option.SliderDisplayItems, option.SliderValues.Count);
        var halfDisplay = displayItems / 2;
        var startIdx = option.SelectedIndex - halfDisplay;
        var values = new List<string>();

        for (int k = 0; k < displayItems; k++)
        {
            var idx = (startIdx + k + option.SliderValues.Count) % option.SliderValues.Count;
            values.Add(idx == option.SelectedIndex ? $"<font color='{(isCurrent ? colHex : "white")}'>[ {option.SliderValues[idx]} ]</font>" : option.SliderValues[idx].ToString()!);
        }

        return isCurrent ? $"<font color='grey' class='fontSize-m'>{string.Join(" ", values)}</font>" : $"<font color='white' class='fontSize-m'>{string.Join(" ", values)}</font>";
    }

    private string RenderMenuItem(IMenuOption option, int originalIdx, string colHex)
    {
        var prefix = Manager!.Settings.NavigationPrefix;

        if (originalIdx == CurrentIndex && option.Disabled) return $"<font class='fontSize-m'>{prefix} {option.Display}</font>";
        if (option.Disabled) return $"<font color='grey' class='fontSize-m'>{option.Display}</font>";
        if (originalIdx != CurrentIndex) return $"<font class='fontSize-m'>{option.Display}</font>";

        var displayText = option.Type == OptionType.Input && Manager.HasInputState(Manager.GetPlayerFromMenu(this)!) ? $"[ {option.Display} ]" : option.Display;

        return $"<font color='{colHex}' class='fontSize-m'>{prefix} {displayText}</font>";
    }

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
                    option.Value = option.Value is false;

                    bool disabled = option.Value is false;
                    option.Display = $"{(!disabled ? "[<font color='green'>✔</font>]" : "[<font color='red'>❌</font>]")} {display}";
                    if (onChoice != null) onChoice!(player, option, menu);
                    Rerender();
                }
            },
        });

        Rerender();

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
                    if (inputRequestMessage != null) player.SendMessage(MessageType.Chat, inputRequestMessage);
                    Manager.SetInputState(player, (p, o, m, s) =>
                    {
                        option.Value = s;
                        o.Display = $"{display}: {s}";
                        onInput!(p, o, m, s);
                        Rerender();
                    });
                }
            },
        });

        Rerender();

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
            OnChoice = defaultDisabled ? null : (IPlayer player, IMenuOption option, IMenu menu) =>
            {
                if (onChoice != null) onChoice!(player, option, menu);
                Rerender();
            },
        });

        Rerender();

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
                Display = defaultDisabled ? $"<font color='grey'>{display}</font>" : $"{display}",
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

                        idx++;
                        if (idx >= option.SliderValues.Count)
                            idx = 0;

                        option.Value = option.SliderValues[idx];
                        if (onSlide != null) onSlide!(player, option, menu, idx, option.Value);

                        Rerender();
                    }
                },
            });
        }

        Rerender();

        return ref CollectionsMarshal.AsSpan(Options)[^1];
    }

    public void ChangePosition(int count)
    {
        CurrentIndex += count;
        if (CurrentIndex < 0) CurrentIndex += Options.Count;
        else if (CurrentIndex > Options.Count - 1) CurrentIndex %= Options.Count;

        Rerender();
    }
}