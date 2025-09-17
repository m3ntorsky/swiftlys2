using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "buytime_ended"
/// </summary>
public interface EventBuytimeEnded : ITypedGameEvent<EventBuytimeEnded> {

  static EventBuytimeEnded ITypedGameEvent<EventBuytimeEnded>.Wrap(IGameEvent accessor) => new EventBuytimeEndedImpl(accessor);

  static string ITypedGameEvent<EventBuytimeEnded>.GetName() => "buytime_ended";

  static uint ITypedGameEvent<EventBuytimeEnded>.GetHash() => 0x95E836E5u;
}
