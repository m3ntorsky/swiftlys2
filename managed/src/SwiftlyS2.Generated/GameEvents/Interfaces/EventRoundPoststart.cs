using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_poststart"
/// sent after all other round restart actions
/// </summary>
public interface EventRoundPoststart : IGameEvent<EventRoundPoststart> {

  static EventRoundPoststart IGameEvent<EventRoundPoststart>.FromAllocated(nint ptr) => new EventRoundPoststartImpl(ptr, true);

  static EventRoundPoststart IGameEvent<EventRoundPoststart>.FromExternal(nint ptr) => new EventRoundPoststartImpl(ptr, false);

  static string IGameEvent<EventRoundPoststart>.GetName() => "round_poststart";

  static uint IGameEvent<EventRoundPoststart>.GetHash() => 0x0BE43746u;
}
