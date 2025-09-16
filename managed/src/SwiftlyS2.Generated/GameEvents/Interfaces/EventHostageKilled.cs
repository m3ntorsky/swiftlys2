using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostage_killed"
/// </summary>
public interface EventHostageKilled : IGameEvent<EventHostageKilled> {

  static EventHostageKilled IGameEvent<EventHostageKilled>.FromAllocated(nint ptr) => new EventHostageKilledImpl(ptr, true);

  static EventHostageKilled IGameEvent<EventHostageKilled>.FromExternal(nint ptr) => new EventHostageKilledImpl(ptr, false);

  static string IGameEvent<EventHostageKilled>.GetName() => "hostage_killed";

  static uint IGameEvent<EventHostageKilled>.GetHash() => 0x0B1DFB8Au;
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
