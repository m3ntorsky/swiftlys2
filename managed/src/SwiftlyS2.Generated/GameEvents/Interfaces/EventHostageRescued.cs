using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostage_rescued"
/// </summary>
public interface EventHostageRescued : IGameEvent<EventHostageRescued> {

  static EventHostageRescued IGameEvent<EventHostageRescued>.Create() => new EventHostageRescuedImpl();

  static string IGameEvent<EventHostageRescued>.GetName() => "hostage_rescued";

  static uint IGameEvent<EventHostageRescued>.GetHash() => 0x46CA33D6u;
  /// <summary>
  /// player who rescued the hostage
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// player who rescued the hostage
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// player who rescued the hostage
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

  /// <summary>
  /// rescue site index
  /// <br/>
  /// type: short
  /// </summary>
  short Site { get; set; }

}
