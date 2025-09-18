using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_beep"
/// </summary>
public interface EventBombBeep : IGameEvent<EventBombBeep> {

  static EventBombBeep IGameEvent<EventBombBeep>.Create() => new EventBombBeepImpl();

  static string IGameEvent<EventBombBeep>.GetName() => "bomb_beep";

  static uint IGameEvent<EventBombBeep>.GetHash() => 0x056A0D22u;
  /// <summary>
  /// c4 entity
  /// <br/>
  /// type: long
  /// </summary>
  int EntIndex { get; set; }

}
