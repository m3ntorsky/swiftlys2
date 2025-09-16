using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_start"
/// </summary>
public interface EventRoundStart : IGameEvent<EventRoundStart> {

  static EventRoundStart IGameEvent<EventRoundStart>.FromAllocated(nint ptr) => new EventRoundStartImpl(ptr, true);

  static EventRoundStart IGameEvent<EventRoundStart>.FromExternal(nint ptr) => new EventRoundStartImpl(ptr, false);

  static string IGameEvent<EventRoundStart>.GetName() => "round_start";

  static uint IGameEvent<EventRoundStart>.GetHash() => 0xAFCD8F60u;
  /// <summary>
  /// round time limit in seconds
  /// <br/>
  /// type: long
  /// </summary>
  int TimeLimit { get; set; }

  /// <summary>
  /// frag limit in seconds
  /// <br/>
  /// type: long
  /// </summary>
  int FragLimit { get; set; }

  /// <summary>
  /// round objective
  /// <br/>
  /// type: string
  /// </summary>
  string Objective { get; set; }

}
