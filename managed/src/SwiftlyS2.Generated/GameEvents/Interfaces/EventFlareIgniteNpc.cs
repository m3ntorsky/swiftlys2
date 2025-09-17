using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "flare_ignite_npc"
/// </summary>
public interface EventFlareIgniteNpc : ITypedGameEvent<EventFlareIgniteNpc> {

  static EventFlareIgniteNpc ITypedGameEvent<EventFlareIgniteNpc>.Wrap(IGameEvent accessor) => new EventFlareIgniteNpcImpl(accessor);

  static string ITypedGameEvent<EventFlareIgniteNpc>.GetName() => "flare_ignite_npc";

  static uint ITypedGameEvent<EventFlareIgniteNpc>.GetHash() => 0xDB89EE8Eu;
  /// <summary>
  /// entity ignited
  /// <br/>
  /// type: long
  /// </summary>
  int EntIndex { get; set; }

}
