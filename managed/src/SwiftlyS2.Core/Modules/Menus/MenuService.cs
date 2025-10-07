using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Misc;

namespace SwiftlyS2.Core.Menus;

internal class MenuService
{
    private readonly ISwiftlyCore _core;
    private Guid ClientChatHook;

    public MenuService(ISwiftlyCore core)
    {
        _core = core;
        _core.Event.OnClientKeyStateChanged += OnClientKeyStateChanged;
        ClientChatHook = _core.Command.HookClientChat(OnClientText);
    }

    ~MenuService()
    {
        _core.Event.OnClientKeyStateChanged -= OnClientKeyStateChanged;
        _core.Command.UnhookClientChat(ClientChatHook);
    }

    private void OnClientKeyStateChanged(IOnClientKeyStateChangedEvent @event)
    {
    }

    private HookResult OnClientText(int playerid, string message, bool teamonly)
    {
        return HookResult.Continue;
    }
}