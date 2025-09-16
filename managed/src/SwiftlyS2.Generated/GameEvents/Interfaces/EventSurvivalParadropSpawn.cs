using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_paradrop_spawn"
/// </summary>
public interface EventSurvivalParadropSpawn : IGameEvent<EventSurvivalParadropSpawn> {

  static EventSurvivalParadropSpawn IGameEvent<EventSurvivalParadropSpawn>.FromAllocated(nint ptr) => new EventSurvivalParadropSpawnImpl(ptr, true);

  static EventSurvivalParadropSpawn IGameEvent<EventSurvivalParadropSpawn>.FromExternal(nint ptr) => new EventSurvivalParadropSpawnImpl(ptr, false);

  static string IGameEvent<EventSurvivalParadropSpawn>.GetName() => "survival_paradrop_spawn";

  static uint IGameEvent<EventSurvivalParadropSpawn>.GetHash() => 0x8F273993u;
  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

}
