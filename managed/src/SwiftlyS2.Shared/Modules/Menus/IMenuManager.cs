using SwiftlyS2.Shared.Players;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Shared.Menus;

public struct MenuSettings
{
    public string NavigationPrefix;
    public string InputMode;
    public string ButtonsUse;
    public string ButtonsScroll;
    public string ButtonsExit;
    public string SoundUseName;
    public float SoundUseVolume;
    public string SoundScrollName;
    public float SoundScrollVolume;
    public string SoundExitName;
    public float SoundExitVolume;
    public int ItemsPerPage;
}


public interface IMenuManager
{
    public IMenu CreateMenu(string title, bool freezePlayer, bool hasSound, bool canExit);
    public void OpenMenu(IPlayer player, IMenu menu);
    public void CloseMenu(IPlayer player);
    public bool IsMenuOpen(IPlayer player);
    public IMenu? GetCurrentMenu(IPlayer player);
    public void OpenSubMenu(IPlayer player, IMenu menu);

    public void SetInputState(IPlayer player, Action<IPlayer, IMenuOption, IMenu, string>? onInput);
    public bool HasInputState(IPlayer player);
    public Action<IPlayer, IMenuOption, IMenu, string>? GetInputState(IPlayer player);

    public void RenderForPlayer(IPlayer player);
    public void ClearRenderForPlayer(IPlayer player);

    public event Action<IPlayer, IMenu>? OnMenuOpened;
    public event Action<IPlayer, IMenu>? OnMenuClosed;
    public MenuSettings Settings { get; }
}