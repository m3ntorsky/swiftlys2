using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "survival_paradrop_spawn"
/// </summary>
internal class EventSurvivalParadropSpawnImpl : GameEvent<EventSurvivalParadropSpawn>, EventSurvivalParadropSpawn
{

  public EventSurvivalParadropSpawnImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public short EntityID
  { get => (short)GetInt("entityid"); set => SetInt("entityid", value); }
}
