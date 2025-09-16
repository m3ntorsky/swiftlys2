using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostage_rescued_all"
/// </summary>
public interface EventHostageRescuedAll : IGameEvent<EventHostageRescuedAll> {

  static EventHostageRescuedAll IGameEvent<EventHostageRescuedAll>.FromAllocated(nint ptr) => new EventHostageRescuedAllImpl(ptr, true);

  static EventHostageRescuedAll IGameEvent<EventHostageRescuedAll>.FromExternal(nint ptr) => new EventHostageRescuedAllImpl(ptr, false);

  static string IGameEvent<EventHostageRescuedAll>.GetName() => "hostage_rescued_all";

  static uint IGameEvent<EventHostageRescuedAll>.GetHash() => 0x9A8C08CEu;
}
