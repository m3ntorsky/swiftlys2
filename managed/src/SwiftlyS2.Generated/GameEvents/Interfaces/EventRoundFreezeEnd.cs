using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_freeze_end"
/// </summary>
public interface EventRoundFreezeEnd : ITypedGameEvent<EventRoundFreezeEnd> {

  static EventRoundFreezeEnd ITypedGameEvent<EventRoundFreezeEnd>.Wrap(IGameEvent accessor) => new EventRoundFreezeEndImpl(accessor);

  static string ITypedGameEvent<EventRoundFreezeEnd>.GetName() => "round_freeze_end";

  static uint ITypedGameEvent<EventRoundFreezeEnd>.GetHash() => 0xD704819Du;
}
