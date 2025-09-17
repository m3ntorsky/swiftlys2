using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_start_pre_entity"
/// </summary>
public interface EventRoundStartPreEntity : ITypedGameEvent<EventRoundStartPreEntity> {

  static EventRoundStartPreEntity ITypedGameEvent<EventRoundStartPreEntity>.Wrap(IGameEvent accessor) => new EventRoundStartPreEntityImpl(accessor);

  static string ITypedGameEvent<EventRoundStartPreEntity>.GetName() => "round_start_pre_entity";

  static uint ITypedGameEvent<EventRoundStartPreEntity>.GetHash() => 0x703715ECu;
}
