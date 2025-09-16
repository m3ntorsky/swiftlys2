using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "nextlevel_changed"
/// a game event, name may be 32 characters long
/// </summary>
public interface EventNextlevelChanged : IGameEvent<EventNextlevelChanged> {

  static EventNextlevelChanged IGameEvent<EventNextlevelChanged>.FromAllocated(nint ptr) => new EventNextlevelChangedImpl(ptr, true);

  static EventNextlevelChanged IGameEvent<EventNextlevelChanged>.FromExternal(nint ptr) => new EventNextlevelChangedImpl(ptr, false);

  static string IGameEvent<EventNextlevelChanged>.GetName() => "nextlevel_changed";

  static uint IGameEvent<EventNextlevelChanged>.GetHash() => 0xAD2E0EA9u;
  /// <summary>
  /// type: string
  /// </summary>
  string NextLevel { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string MapGroup { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string SkirmishMode { get; set; }

}
