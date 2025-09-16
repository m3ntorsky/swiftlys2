using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "demo_skip"
/// </summary>
public interface EventDemoSkip : IGameEvent<EventDemoSkip> {

  static EventDemoSkip IGameEvent<EventDemoSkip>.FromAllocated(nint ptr) => new EventDemoSkipImpl(ptr, true);

  static EventDemoSkip IGameEvent<EventDemoSkip>.FromExternal(nint ptr) => new EventDemoSkipImpl(ptr, false);

  static string IGameEvent<EventDemoSkip>.GetName() => "demo_skip";

  static uint IGameEvent<EventDemoSkip>.GetHash() => 0x3A36ECC0u;
  /// <summary>
  /// current playback tick
  /// <br/>
  /// type: long
  /// </summary>
  int PlaybackTick { get; set; }

  /// <summary>
  /// tick we're going to
  /// <br/>
  /// type: long
  /// </summary>
  int SkiptoTick { get; set; }

}
