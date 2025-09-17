using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_changed_mode"
/// </summary>
public interface EventHltvChangedMode : ITypedGameEvent<EventHltvChangedMode> {

  static EventHltvChangedMode ITypedGameEvent<EventHltvChangedMode>.Wrap(IGameEvent accessor) => new EventHltvChangedModeImpl(accessor);

  static string ITypedGameEvent<EventHltvChangedMode>.GetName() => "hltv_changed_mode";

  static uint ITypedGameEvent<EventHltvChangedMode>.GetHash() => 0x11795622u;
  /// <summary>
  /// type: long
  /// </summary>
  int OldMode { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int NewMode { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int ObsTarget { get; set; }

}
