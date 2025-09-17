using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_full_update"
/// </summary>
public interface EventPlayerFullUpdate : ITypedGameEvent<EventPlayerFullUpdate> {

  static EventPlayerFullUpdate ITypedGameEvent<EventPlayerFullUpdate>.Wrap(IGameEvent accessor) => new EventPlayerFullUpdateImpl(accessor);

  static string ITypedGameEvent<EventPlayerFullUpdate>.GetName() => "player_full_update";

  static uint ITypedGameEvent<EventPlayerFullUpdate>.GetHash() => 0xC12FF460u;
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
