using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_poststart"
/// sent after all other round restart actions
/// </summary>
public interface EventRoundPoststart : ITypedGameEvent<EventRoundPoststart> {

  static EventRoundPoststart ITypedGameEvent<EventRoundPoststart>.Wrap(IGameEvent accessor) => new EventRoundPoststartImpl(accessor);

  static string ITypedGameEvent<EventRoundPoststart>.GetName() => "round_poststart";

  static uint ITypedGameEvent<EventRoundPoststart>.GetHash() => 0x0BE43746u;
}
