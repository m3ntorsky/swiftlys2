using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Shared.Menus;

public interface IMenuManager
{
    public IMenu CreateMenu(string title, bool freezePlayer, bool hasSound, bool isSubMenu, bool canExit);
    public void OpenMenu(IPlayer player, IMenu menu);
    public void CloseMenu(IPlayer player);
    public bool IsMenuOpen(IPlayer player);
    public IMenu? GetCurrentMenu(IPlayer player);
    public void OpenSubMenu(IPlayer player, IMenu menu);

    public event Action<IPlayer, IMenu>? OnMenuOpened;
    public event Action<IPlayer, IMenu>? OnMenuClosed;
}