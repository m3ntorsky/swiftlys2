using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "grenade_thrown"
/// </summary>
public interface EventGrenadeThrown : IGameEvent<EventGrenadeThrown> {

  static EventGrenadeThrown IGameEvent<EventGrenadeThrown>.FromAllocated(nint ptr) => new EventGrenadeThrownImpl(ptr, true);

  static EventGrenadeThrown IGameEvent<EventGrenadeThrown>.FromExternal(nint ptr) => new EventGrenadeThrownImpl(ptr, false);

  static string IGameEvent<EventGrenadeThrown>.GetName() => "grenade_thrown";

  static uint IGameEvent<EventGrenadeThrown>.GetHash() => 0x0F018978u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// weapon name used
  /// <br/>
  /// type: string
  /// </summary>
  string Weapon { get; set; }

}
