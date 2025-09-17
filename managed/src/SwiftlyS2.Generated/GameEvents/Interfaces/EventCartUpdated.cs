using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cart_updated"
/// </summary>
public interface EventCartUpdated : ITypedGameEvent<EventCartUpdated> {

  static EventCartUpdated ITypedGameEvent<EventCartUpdated>.Wrap(IGameEvent accessor) => new EventCartUpdatedImpl(accessor);

  static string ITypedGameEvent<EventCartUpdated>.GetName() => "cart_updated";

  static uint ITypedGameEvent<EventCartUpdated>.GetHash() => 0x3A4BF24Fu;
}
