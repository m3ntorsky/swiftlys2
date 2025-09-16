using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "buytime_ended"
/// </summary>
public interface EventBuytimeEnded : IGameEvent<EventBuytimeEnded> {

  static EventBuytimeEnded IGameEvent<EventBuytimeEnded>.FromAllocated(nint ptr) => new EventBuytimeEndedImpl(ptr, true);

  static EventBuytimeEnded IGameEvent<EventBuytimeEnded>.FromExternal(nint ptr) => new EventBuytimeEndedImpl(ptr, false);

  static string IGameEvent<EventBuytimeEnded>.GetName() => "buytime_ended";

  static uint IGameEvent<EventBuytimeEnded>.GetHash() => 0x95E836E5u;
}
