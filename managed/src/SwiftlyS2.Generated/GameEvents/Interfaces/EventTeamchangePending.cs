using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "teamchange_pending"
/// </summary>
public interface EventTeamchangePending : ITypedGameEvent<EventTeamchangePending> {

  static EventTeamchangePending ITypedGameEvent<EventTeamchangePending>.Wrap(IGameEvent accessor) => new EventTeamchangePendingImpl(accessor);

  static string ITypedGameEvent<EventTeamchangePending>.GetName() => "teamchange_pending";

  static uint ITypedGameEvent<EventTeamchangePending>.GetHash() => 0x53F97450u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte ToTeam { get; set; }

}
