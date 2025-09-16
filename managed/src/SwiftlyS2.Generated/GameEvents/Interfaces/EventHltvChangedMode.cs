using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_changed_mode"
/// </summary>
public interface EventHltvChangedMode : IGameEvent<EventHltvChangedMode> {

  static EventHltvChangedMode IGameEvent<EventHltvChangedMode>.FromAllocated(nint ptr) => new EventHltvChangedModeImpl(ptr, true);

  static EventHltvChangedMode IGameEvent<EventHltvChangedMode>.FromExternal(nint ptr) => new EventHltvChangedModeImpl(ptr, false);

  static string IGameEvent<EventHltvChangedMode>.GetName() => "hltv_changed_mode";

  static uint IGameEvent<EventHltvChangedMode>.GetHash() => 0x11795622u;
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
