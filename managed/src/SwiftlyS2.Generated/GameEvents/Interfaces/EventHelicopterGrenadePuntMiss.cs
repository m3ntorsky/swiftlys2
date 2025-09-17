using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "helicopter_grenade_punt_miss"
/// </summary>
public interface EventHelicopterGrenadePuntMiss : ITypedGameEvent<EventHelicopterGrenadePuntMiss> {

  static EventHelicopterGrenadePuntMiss ITypedGameEvent<EventHelicopterGrenadePuntMiss>.Create() => new EventHelicopterGrenadePuntMissImpl();

  static string ITypedGameEvent<EventHelicopterGrenadePuntMiss>.GetName() => "helicopter_grenade_punt_miss";

  static uint ITypedGameEvent<EventHelicopterGrenadePuntMiss>.GetHash() => 0xB6DF8460u;
}
