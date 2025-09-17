using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "demo_skip"
/// </summary>
public interface EventDemoSkip : ITypedGameEvent<EventDemoSkip> {

  static EventDemoSkip ITypedGameEvent<EventDemoSkip>.Create() => new EventDemoSkipImpl();

  static string ITypedGameEvent<EventDemoSkip>.GetName() => "demo_skip";

  static uint ITypedGameEvent<EventDemoSkip>.GetHash() => 0x3A36ECC0u;
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
