using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "grenade_bounce"
/// </summary>
public interface EventGrenadeBounce : IGameEvent<EventGrenadeBounce> {

  static EventGrenadeBounce IGameEvent<EventGrenadeBounce>.FromAllocated(nint ptr) => new EventGrenadeBounceImpl(ptr, true);

  static EventGrenadeBounce IGameEvent<EventGrenadeBounce>.FromExternal(nint ptr) => new EventGrenadeBounceImpl(ptr, false);

  static string IGameEvent<EventGrenadeBounce>.GetName() => "grenade_bounce";

  static uint IGameEvent<EventGrenadeBounce>.GetHash() => 0xF75C5166u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
