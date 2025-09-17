using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_prestart"
/// sent before all other round restart actions
/// </summary>
public interface EventRoundPrestart : ITypedGameEvent<EventRoundPrestart> {

  static EventRoundPrestart ITypedGameEvent<EventRoundPrestart>.Wrap(IGameEvent accessor) => new EventRoundPrestartImpl(accessor);

  static string ITypedGameEvent<EventRoundPrestart>.GetName() => "round_prestart";

  static uint ITypedGameEvent<EventRoundPrestart>.GetHash() => 0xE6A3E50Fu;
}
