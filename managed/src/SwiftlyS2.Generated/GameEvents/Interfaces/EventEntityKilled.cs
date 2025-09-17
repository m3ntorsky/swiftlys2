using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "entity_killed"
/// </summary>
public interface EventEntityKilled : ITypedGameEvent<EventEntityKilled> {

  static EventEntityKilled ITypedGameEvent<EventEntityKilled>.Wrap(IGameEvent accessor) => new EventEntityKilledImpl(accessor);

  static string ITypedGameEvent<EventEntityKilled>.GetName() => "entity_killed";

  static uint ITypedGameEvent<EventEntityKilled>.GetHash() => 0x6B63D08Eu;
  /// <summary>
  /// type: long
  /// </summary>
  int EntindexKilled { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int EntindexAttacker { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int EntindexInflictor { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int DamageBits { get; set; }

}
