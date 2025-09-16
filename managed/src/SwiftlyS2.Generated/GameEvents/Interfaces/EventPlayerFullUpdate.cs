using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_full_update"
/// </summary>
public interface EventPlayerFullUpdate : IGameEvent<EventPlayerFullUpdate> {

  static EventPlayerFullUpdate IGameEvent<EventPlayerFullUpdate>.FromAllocated(nint ptr) => new EventPlayerFullUpdateImpl(ptr, true);

  static EventPlayerFullUpdate IGameEvent<EventPlayerFullUpdate>.FromExternal(nint ptr) => new EventPlayerFullUpdateImpl(ptr, false);

  static string IGameEvent<EventPlayerFullUpdate>.GetName() => "player_full_update";

  static uint IGameEvent<EventPlayerFullUpdate>.GetHash() => 0xC12FF460u;
  /// <summary>
  /// user ID on server
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// Number of this full update
  /// <br/>
  /// type: short
  /// </summary>
  short Count { get; set; }

}
