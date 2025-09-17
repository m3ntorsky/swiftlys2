using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "drop_rate_modified"
/// </summary>
public interface EventDropRateModified : ITypedGameEvent<EventDropRateModified> {

  static EventDropRateModified ITypedGameEvent<EventDropRateModified>.Create() => new EventDropRateModifiedImpl();

  static string ITypedGameEvent<EventDropRateModified>.GetName() => "drop_rate_modified";

  static uint ITypedGameEvent<EventDropRateModified>.GetHash() => 0x4D5A279Bu;
}
