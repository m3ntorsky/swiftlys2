using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Menus;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.Players;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.Sounds;

namespace SwiftlyS2.Core.Menus;

internal class MenuService
{
    private readonly ISwiftlyCore _core;
    private Guid ClientChatHook;

    private static readonly Dictionary<string, KeyKind> StringToKeyKind = new()
    {
        { "mouse1", KeyKind.Mouse1 },
        { "mouse2", KeyKind.Mouse2 },
        { "space", KeyKind.Space },
        { "ctrl", KeyKind.Ctrl },
        { "w", KeyKind.W },
        { "a", KeyKind.A },
        { "s", KeyKind.S },
        { "d", KeyKind.D },
        { "e", KeyKind.E },
        { "esc", KeyKind.Esc },
        { "r", KeyKind.R },
        { "alt", KeyKind.Alt },
        { "shift", KeyKind.Shift },
        { "weapon1", KeyKind.Weapon1 },
        { "weapon2", KeyKind.Weapon2 },
        { "grenade1", KeyKind.Grenade1 },
        { "grenade2", KeyKind.Grenade2 },
        { "tab", KeyKind.Tab },
        { "f", KeyKind.F },
    };

    private SoundEvent _useSound = new();
    private SoundEvent _exitSound = new();
    private SoundEvent _scrollSound = new();

    public MenuService(ISwiftlyCore core)
    {
        _core = core;
        _core.Event.OnClientKeyStateChanged += OnClientKeyStateChanged;
        ClientChatHook = _core.Command.HookClientChat(OnClientText);

        _scrollSound.Name = _core.Menus.Settings.SoundScrollName;
        _scrollSound.Volume = _core.Menus.Settings.SoundScrollVolume;

        _useSound.Name = _core.Menus.Settings.SoundUseName;
        _useSound.Volume = _core.Menus.Settings.SoundUseVolume;

        _exitSound.Name = _core.Menus.Settings.SoundExitName;
        _exitSound.Volume = _core.Menus.Settings.SoundExitVolume;
    }

    ~MenuService()
    {
        _core.Event.OnClientKeyStateChanged -= OnClientKeyStateChanged;
        _core.Command.UnhookClientChat(ClientChatHook);
    }

    private void OnClientKeyStateChanged(IOnClientKeyStateChangedEvent @event)
    {
        var player = _core.PlayerManager.GetPlayer(@event.PlayerId);
        var menu = _core.Menus.GetCurrentMenu(player);
        if (menu == null) return;

        if (_core.Menus.Settings.InputMode == "button")
        {
            var scrollKey = StringToKeyKind.GetValueOrDefault(_core.Menus.Settings.ButtonsScroll);
            var exitKey = StringToKeyKind.GetValueOrDefault(_core.Menus.Settings.ButtonsExit);
            var useKey = StringToKeyKind.GetValueOrDefault(_core.Menus.Settings.ButtonsUse);

            if (@event.Key == scrollKey && @event.Pressed)
            {
                menu.ChangePosition(1);

                if (menu.HasSound)
                {
                    _scrollSound.Recipients.AddRecipient(@event.PlayerId);
                    _scrollSound.Emit();
                    _scrollSound.Recipients.RemoveRecipient(@event.PlayerId);
                }
            }
            else if (@event.Key == exitKey && @event.Pressed && menu.CanExit)
            {
                _core.Menus.CloseMenu(player);

                if (menu.HasSound)
                {
                    _exitSound.Recipients.AddRecipient(@event.PlayerId);
                    _exitSound.Emit();
                    _exitSound.Recipients.RemoveRecipient(@event.PlayerId);
                }
            }
            else if (@event.Key == useKey && @event.Pressed)
            {
                var option = menu.Options[menu.CurrentIndex];
                if (!option.Disabled && option.OnChoice != null)
                {
                    option.OnChoice(player, option, menu);
                    if (menu.HasSound)
                    {
                        _useSound.Recipients.AddRecipient(@event.PlayerId);
                        _useSound.Emit();
                        _useSound.Recipients.RemoveRecipient(@event.PlayerId);
                    }
                }
            }
        }
        else if (_core.Menus.Settings.InputMode == "wasd")
        {
            if (@event.Key == KeyKind.W && @event.Pressed)
            {
                menu.ChangePosition(-1);

                if (menu.HasSound)
                {
                    _scrollSound.Recipients.AddRecipient(@event.PlayerId);
                    _scrollSound.Emit();
                    _scrollSound.Recipients.RemoveRecipient(@event.PlayerId);
                }
            }
            else if (@event.Key == KeyKind.S && @event.Pressed)
            {
                menu.ChangePosition(1);

                if (menu.HasSound)
                {
                    _scrollSound.Recipients.AddRecipient(@event.PlayerId);
                    _scrollSound.Emit();
                    _scrollSound.Recipients.RemoveRecipient(@event.PlayerId);
                }
            }
            else if (@event.Key == KeyKind.A && @event.Pressed && menu.CanExit)
            {
                _core.Menus.CloseMenu(player);

                if (menu.HasSound)
                {
                    _exitSound.Recipients.AddRecipient(@event.PlayerId);
                    _exitSound.Emit();
                    _exitSound.Recipients.RemoveRecipient(@event.PlayerId);
                }
            }
            else if (@event.Key == KeyKind.D && @event.Pressed)
            {
                var option = menu.Options[menu.CurrentIndex];
                if (!option.Disabled && option.OnChoice != null)
                {
                    option.OnChoice(player, option, menu);
                    if (menu.HasSound)
                    {
                        _useSound.Recipients.AddRecipient(@event.PlayerId);
                        _useSound.Emit();
                        _useSound.Recipients.RemoveRecipient(@event.PlayerId);
                    }
                }
            }
        }
    }

    private HookResult OnClientText(int playerid, string message, bool teamonly)
    {
        var player = _core.PlayerManager.GetPlayer(playerid);
        if (player == null) return HookResult.Continue;

        var state = _core.Menus.GetInputState(player);
        if (state == null) return HookResult.Continue;

        var menu = _core.Menus.GetCurrentMenu(player);
        if (menu == null) return HookResult.Continue;

        state(player, menu.Options[menu.CurrentIndex], menu, message);
        _core.Menus.SetInputState(player, null);
        return HookResult.Continue;
    }
}