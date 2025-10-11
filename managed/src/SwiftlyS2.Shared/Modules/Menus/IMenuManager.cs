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
    /// <summary>
    /// Creates a new menu instance.
    /// </summary>
    /// <param name="title">The title of the menu.</param>
    /// <param name="freezePlayer">Whether to freeze the player while the menu is open.</param>
    /// <param name="hasSound">Whether the menu has sound effects.</param>
    /// <param name="canExit">Whether the menu can be exited.</param>
    /// <returns>Menu Object</returns>
    public IMenu CreateMenu(string title, bool freezePlayer, bool hasSound, bool canExit);
    /// <summary>
    /// Opens a menu for a player.
    /// </summary>
    public void OpenMenu(IPlayer player, IMenu menu);
    /// <summary>
    /// Opens a menu for a player with auto-close functionality.
    /// </summary>
    /// <param name="player">The player to open the menu for.</param>
    /// <param name="menu">The menu to open.</param>
    /// <param name="autoCloseDelay">Time in seconds before auto-close. Values less than 1/64 second disable auto-close.</param>
    public void OpenMenu(IPlayer player, IMenu menu, float autoCloseDelay);
    /// <summary>
    /// Closes the current menu for a player.
    /// </summary>
    public void CloseMenu(IPlayer player);
    /// <summary>
    /// Gets the player associated with a menu.
    /// </summary>
    public IPlayer? GetPlayerFromMenu(IMenu menu);
    /// <summary>
    /// Checks if a menu is currently open for a player.
    /// </summary>
    public bool IsMenuOpen(IPlayer player);
    /// <summary>
    /// Gets the current menu for a player, or null if no menu is open.
    /// </summary>
    public IMenu? GetCurrentMenu(IPlayer player);
    /// <summary>
    /// Opens a submenu for a player, closing the current menu.
    /// </summary>
    public void OpenSubMenu(IPlayer player, IMenu menu);
    /// <summary>
    /// Opens a submenu for a player with auto-close functionality.
    /// </summary>
    /// <param name="player">The player to open the submenu for.</param>
    /// <param name="menu">The submenu to open.</param>
    /// <param name="autoCloseDelay">Time in seconds before auto-close. Values less than 1/64 second disable auto-close.</param>
    public void OpenSubMenu(IPlayer player, IMenu menu, float autoCloseDelay);

    /// <summary>
    /// Sets an input state callback for a player.
    /// </summary>
    public void SetInputState(IPlayer player, Action<IPlayer, IMenuOption, IMenu, string>? onInput);
    /// <summary>
    /// Checks if a player has an input state callback set.
    /// </summary>
    public bool HasInputState(IPlayer player);
    /// <summary>
    /// Gets the input state callback for a player.
    /// </summary>
    public Action<IPlayer, IMenuOption, IMenu, string>? GetInputState(IPlayer player);

    public void RenderForPlayer(IPlayer player);
    public void ClearRenderForPlayer(IPlayer player);

    /// <summary>
    /// Event triggered when a menu is opened.
    /// </summary>
    public event Action<IPlayer, IMenu>? OnMenuOpened;
    /// <summary>
    /// Event triggered when a menu is closed.
    /// </summary>
    public event Action<IPlayer, IMenu>? OnMenuClosed;
    /// <summary>
    /// Menu settings.
    /// </summary>
    public MenuSettings Settings { get; }
}