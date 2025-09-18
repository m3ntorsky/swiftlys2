using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostage_follows"
/// </summary>
public interface EventHostageFollows : IGameEvent<EventHostageFollows> {

  static EventHostageFollows IGameEvent<EventHostageFollows>.Create() => new EventHostageFollowsImpl();

  static string IGameEvent<EventHostageFollows>.GetName() => "hostage_follows";

  static uint IGameEvent<EventHostageFollows>.GetHash() => 0xEC398ED7u;
  /// <summary>
  /// player who touched the hostage
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// player who touched the hostage
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// player who touched the hostage
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  int UserId { get; set; }

  /// <summary>
  /// hostage entity index
  /// <br/>
  /// type: short
  /// </summary>
  short Hostage { get; set; }

}
