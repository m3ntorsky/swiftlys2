using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Menus;
using SwiftlyS2.Shared.Players;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Menus;

internal class MenuManager : IMenuManager
{
    private static readonly Dictionary<IPlayer, IMenu> OpenMenus = new();
    private static readonly Dictionary<IPlayer, Stack<IMenu>> MenuHistories = new();
    private static readonly Dictionary<IPlayer, Action<IPlayer, IMenuOption, IMenu, string>?> InputState = new();

    public event Action<IPlayer, IMenu>? OnMenuOpened;
    public event Action<IPlayer, IMenu>? OnMenuClosed;
    public MenuSettings Settings { get; private set; }

    public MenuManager()
    {
        var settings = NativeEngineHelpers.GetMenuSettings();
        var parts = settings.Split('\x01');
        Settings = new MenuSettings
        {
            NavigationPrefix = parts[0],
            InputMode = parts[1],
            ButtonsUse = parts[2],
            ButtonsScroll = parts[3],
            ButtonsExit = parts[4],
            SoundUseName = parts[5],
            SoundUseVolume = float.Parse(parts[6]),
            SoundScrollName = parts[7],
            SoundScrollVolume = float.Parse(parts[8]),
            SoundExitName = parts[9],
            SoundExitVolume = float.Parse(parts[10]),
            ItemsPerPage = int.Parse(parts[11]),
        };
    }

    public void CloseMenu(IPlayer player)
    {
        if (OpenMenus.TryGetValue(player, out var menu))
        {
            OpenMenus.Remove(player);
            OnMenuClosed?.Invoke(player, menu);

            if (MenuHistories.TryGetValue(player, out var history) && history.Count > 0)
            {
                var activeMenu = history.Pop();
                if (activeMenu != menu)
                {
                    OpenMenus[player] = activeMenu;
                    OnMenuOpened?.Invoke(player, activeMenu);
                }
                else
                {
                    ClearRenderForPlayer(player);
                }
            }
            else
            {
                ClearRenderForPlayer(player);
            }

            InputState.Remove(player);
        }
    }

    public IPlayer? GetPlayerFromMenu(IMenu menu)
    {
        foreach (var (player, openMenu) in OpenMenus)
            if (openMenu == menu)
                return player;

        return null;
    }

    public IMenu CreateMenu(string title, bool freezePlayer, bool hasSound, bool canExit)
    {
        return new Menu
        {
            Title = title,
            FreezePlayer = freezePlayer,
            HasSound = hasSound,
            CanExit = canExit,
            Kind = MenuType.CenterMenu,
            Manager = this,
        };
    }

    public IMenu? GetCurrentMenu(IPlayer player)
    {
        if (!IsMenuOpen(player)) return null;
        return OpenMenus[player];
    }

    public bool IsMenuOpen(IPlayer player)
    {
        return OpenMenus.ContainsKey(player);
    }

    public void OpenMenu(IPlayer player, IMenu menu)
    {
        if (IsMenuOpen(player))
        {
            MenuHistories.Remove(player);
            CloseMenu(player);
        }

        OpenMenus[player] = menu;
        if (!MenuHistories.ContainsKey(player))
            MenuHistories[player] = new Stack<IMenu>();

        MenuHistories[player].Push(menu);

        OnMenuOpened?.Invoke(player, menu);

        RenderForPlayer(player);
    }

    public void OpenSubMenu(IPlayer player, IMenu menu)
    {
        if (!IsMenuOpen(player))
        {
            OpenMenu(player, menu);
            return;
        }


        if (OpenMenus.TryGetValue(player, out var currentMenu))
        {
            if (!MenuHistories.ContainsKey(player))
                MenuHistories[player] = new Stack<IMenu>();

            MenuHistories[player].Push(currentMenu);
        }

        OpenMenus[player] = menu;
        OnMenuOpened?.Invoke(player, menu);
    }

    public void SetInputState(IPlayer player, Action<IPlayer, IMenuOption, IMenu, string>? onInput)
    {
        if (onInput == null)
        {
            InputState.Remove(player);
            return;
        }

        InputState[player] = onInput;
    }

    public bool HasInputState(IPlayer player)
    {
        return InputState.ContainsKey(player);
    }

    public Action<IPlayer, IMenuOption, IMenu, string>? GetInputState(IPlayer player)
    {
        return InputState.TryGetValue(player, out var state) ? state : null;
    }

    public void RenderForPlayer(IPlayer player)
    {
        if (OpenMenus.TryGetValue(player, out var menu) && menu.RenderText != null)
        {
            if (player.IsFakeClient || !player.IsValid) return;
            NativePlayer.SetCenterMenuRender(player.PlayerID, menu.RenderText);
        }
    }

    public void ClearRenderForPlayer(IPlayer player)
    {
        if (player.IsFakeClient || !player.IsValid) return;
        NativePlayer.ClearCenterMenuRender(player.PlayerID);
    }
}