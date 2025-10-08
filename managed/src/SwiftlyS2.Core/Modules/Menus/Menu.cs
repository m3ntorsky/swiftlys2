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
    public List<IMenuOption>? PreviousOptions { get; set; } = new();
    public bool? FreezePlayer { get; set; } = null;
    public bool HasSound { get; set; } = true;
    public IMenu? ParentMenu { get; set; } = null;
    public bool CanExit { get; set; } = true;
    public MenuType Kind { get; set; } = MenuType.CenterMenu;
    public Color Color { get; set; }
    public IMenuManager? Manager { get; set; } = null;
    public string? RenderText { get; private set; } = null;
    public int CurrentIndex { get; set; } = 0;
    public void Rerender()
    {
        if (Kind == MenuType.CenterMenu)
        {
            var colHex = $"#{Color.R:X2}{Color.G:X2}{Color.B:X2}";
            if (Title.Length > MaxTitleLength)
                Title = Title[..MaxTitleLength];

            var builder = new StringBuilder();
            builder.Append($"<b><font color='{colHex}' class='fontSize-m'>{Title}</font></b> <font class='fontSize-sm'>[{CurrentIndex + 1}/{Options.Count}]</font>");
            builder.Append("<br>");

            var itemsPerPage = Manager!.Settings.ItemsPerPage;
            var halfPage = itemsPerPage / 2;
            var startIdx = CurrentIndex - halfPage;
            var displayCount = Math.Min(itemsPerPage, Options.Count);

            for (int j = 0; j < displayCount; j++)
            {
                int i = ((startIdx + j) % Options.Count + Options.Count) % Options.Count;
                var option = Options[i];

                if (option.Disabled)
                {
                    builder.Append($"<font color='grey' class='fontSize-m'>{option.Display}</font>");
                }
                else if (i == CurrentIndex)
                {
                    if (option.Type == OptionType.Input && Manager!.HasInputState(Manager.GetPlayerFromMenu(this)!))
                    {
                        builder.Append($"<font color='{colHex}' class='fontSize-m'>{(Manager.Settings.InputMode == "chat" ? $"!{i - CurrentIndex + 1} -" : Manager!.Settings.NavigationPrefix)} [ {option.Display} ]</font>");
                    }
                    else if (option.Type == OptionType.Slider)
                    {
                        builder.Append($"<font color='{colHex}' class='fontSize-m'>{(Manager.Settings.InputMode == "chat" ? $"!{i - CurrentIndex + 1} -" : Manager!.Settings.NavigationPrefix)} {option.Display}</font><br>");

                        if (option.SliderValues != null && option.SliderValues.Count > 0)
                        {
                            var displayItems = Math.Min(option.SliderDisplayItems, option.SliderValues.Count);
                            var selectedIdx = option.SelectedIndex;
                            var halfDisplay = displayItems / 2;

                            var displayValues = new List<string>();

                            int sliderStartIdx = selectedIdx - halfDisplay;

                            for (int k = 0; k < displayItems; k++)
                            {
                                int idx = (sliderStartIdx + k + option.SliderValues.Count) % option.SliderValues.Count;
                                if (idx == selectedIdx)
                                    displayValues.Add($"[ {option.SliderValues[idx]} ]");
                                else
                                    displayValues.Add(option.SliderValues[idx].ToString()!);
                            }

                            builder.Append($"<font color='{colHex}' class='fontSize-m'>{(displayValues.Count == 0 ? "Empty" : string.Join(" ", displayValues))}</font>");
                        }
                    }
                    else
                    {
                        builder.Append($"<font color='{colHex}' class='fontSize-m'>{(Manager!.Settings.InputMode == "chat" ? $"!{i - CurrentIndex + 1} -" : Manager!.Settings.NavigationPrefix)} {option.Display}</font>");
                    }
                }
                else if (option.Type == OptionType.Slider)
                {
                    builder.Append($"<font class='fontSize-m'>{option.Display}</font><br>");

                    if (option.SliderValues != null && option.SliderValues.Count > 0)
                    {
                        var displayItems = Math.Min(option.SliderDisplayItems, option.SliderValues.Count);
                        var selectedIdx = option.SelectedIndex;
                        var halfDisplay = displayItems / 2;

                        var displayValues = new List<string>();

                        int sliderStartIdx = selectedIdx - halfDisplay;

                        for (int k = 0; k < displayItems; k++)
                        {
                            int idx = (sliderStartIdx + k + option.SliderValues.Count) % option.SliderValues.Count;
                            if (idx == selectedIdx)
                                displayValues.Add($"[ {option.SliderValues[idx]} ]");
                            else
                                displayValues.Add(option.SliderValues[idx].ToString()!);
                        }

                        builder.Append($"<font class='fontSize-m'>{(displayValues.Count == 0 ? "Empty" : string.Join(" ", displayValues))}</font>");
                    }
                }
                else
                {
                    builder.Append($"<font class='fontSize-m'>{option.Display}</font>");
                }
                builder.Append("<br>");
            }

            if (Manager != null && Manager.Settings.InputMode == "button")
                builder.Append($"<font class='fontSize-s'>Move: [{Manager.Settings.ButtonsScroll.ToUpper()}] | Use: [{Manager.Settings.ButtonsUse.ToUpper()}] | Back: [{Manager.Settings.ButtonsExit.ToUpper()}]</font>");
            else if (Manager != null && Manager.Settings.InputMode == "wasd")
                builder.Append($"<font class='fontSize-s'>Move: [W/S] | Use: [D] | Back: [A]</font>");

            RenderText = builder.ToString();

            if (Manager != null)
            {
                var player = Manager.GetPlayerFromMenu(this);
                if (player != null)
                    Manager.RenderForPlayer(player);
            }
        }
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