using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostage_stops_following"
/// </summary>
public interface EventHostageStopsFollowing : ITypedGameEvent<EventHostageStopsFollowing> {

  static EventHostageStopsFollowing ITypedGameEvent<EventHostageStopsFollowing>.Wrap(IGameEvent accessor) => new EventHostageStopsFollowingImpl(accessor);

  static string ITypedGameEvent<EventHostageStopsFollowing>.GetName() => "hostage_stops_following";

  static uint ITypedGameEvent<EventHostageStopsFollowing>.GetHash() => 0x63B81600u;
  /// <summary>
  /// player who rescued the hostage
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// hostage entity index
  /// <br/>
  /// type: short
  /// </summary>
  short Hostage { get; set; }

}
