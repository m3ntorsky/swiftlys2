using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostage_killed"
/// </summary>
public interface EventHostageKilled : ITypedGameEvent<EventHostageKilled> {

  static EventHostageKilled ITypedGameEvent<EventHostageKilled>.Wrap(IGameEvent accessor) => new EventHostageKilledImpl(accessor);

  static string ITypedGameEvent<EventHostageKilled>.GetName() => "hostage_killed";

  static uint ITypedGameEvent<EventHostageKilled>.GetHash() => 0x0B1DFB8Au;
  /// <summary>
  /// player who killed the hostage
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
