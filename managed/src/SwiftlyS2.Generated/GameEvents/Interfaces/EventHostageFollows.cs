using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostage_follows"
/// </summary>
public interface EventHostageFollows : ITypedGameEvent<EventHostageFollows> {

  static EventHostageFollows ITypedGameEvent<EventHostageFollows>.Create() => new EventHostageFollowsImpl();

  static string ITypedGameEvent<EventHostageFollows>.GetName() => "hostage_follows";

  static uint ITypedGameEvent<EventHostageFollows>.GetHash() => 0xEC398ED7u;
  /// <summary>
  /// player who touched the hostage
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
