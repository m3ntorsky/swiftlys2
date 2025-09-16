using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "drop_rate_modified"
/// </summary>
public interface EventDropRateModified : IGameEvent<EventDropRateModified> {

  static EventDropRateModified IGameEvent<EventDropRateModified>.FromAllocated(nint ptr) => new EventDropRateModifiedImpl(ptr, true);

  static EventDropRateModified IGameEvent<EventDropRateModified>.FromExternal(nint ptr) => new EventDropRateModifiedImpl(ptr, false);

  static string IGameEvent<EventDropRateModified>.GetName() => "drop_rate_modified";

  static uint IGameEvent<EventDropRateModified>.GetHash() => 0x4D5A279Bu;
}
