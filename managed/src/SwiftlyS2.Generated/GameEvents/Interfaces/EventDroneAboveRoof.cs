using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "drone_above_roof"
/// </summary>
public interface EventDroneAboveRoof : ITypedGameEvent<EventDroneAboveRoof> {

  static EventDroneAboveRoof ITypedGameEvent<EventDroneAboveRoof>.Wrap(IGameEvent accessor) => new EventDroneAboveRoofImpl(accessor);

  static string ITypedGameEvent<EventDroneAboveRoof>.GetName() => "drone_above_roof";

  static uint ITypedGameEvent<EventDroneAboveRoof>.GetHash() => 0x647D7762u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short Cargo { get; set; }

}
