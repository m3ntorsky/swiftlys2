using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_paradrop_spawn"
/// </summary>
public interface EventSurvivalParadropSpawn : ITypedGameEvent<EventSurvivalParadropSpawn> {

  static EventSurvivalParadropSpawn ITypedGameEvent<EventSurvivalParadropSpawn>.Create() => new EventSurvivalParadropSpawnImpl();

  static string ITypedGameEvent<EventSurvivalParadropSpawn>.GetName() => "survival_paradrop_spawn";

  static uint ITypedGameEvent<EventSurvivalParadropSpawn>.GetHash() => 0x8F273993u;
  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

}
