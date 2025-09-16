using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "inferno_extinguish"
/// </summary>
internal class EventInfernoExtinguishImpl : GameEvent<EventInfernoExtinguish>, EventInfernoExtinguish
{

  public EventInfernoExtinguishImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public short EntityID
  { get => (short)GetInt("entityid"); set => SetInt("entityid", value); }

  public float X
  { get => GetFloat("x"); set => SetFloat("x", value); }

  public float Y
  { get => GetFloat("y"); set => SetFloat("y", value); }

  public float Z
  { get => GetFloat("z"); set => SetFloat("z", value); }
}
