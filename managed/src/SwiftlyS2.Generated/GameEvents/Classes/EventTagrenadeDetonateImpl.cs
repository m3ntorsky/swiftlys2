using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "tagrenade_detonate"
/// </summary>
internal class EventTagrenadeDetonateImpl : TypedGameEvent<EventTagrenadeDetonate>, EventTagrenadeDetonate
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public short EntityID
  { get => (short)Accessor.GetInt32("entityid"); set => Accessor.SetInt32("entityid", value); }

  public float X
  { get => Accessor.GetFloat("x"); set => Accessor.SetFloat("x", value); }

  public float Y
  { get => Accessor.GetFloat("y"); set => Accessor.SetFloat("y", value); }

  public float Z
  { get => Accessor.GetFloat("z"); set => Accessor.SetFloat("z", value); }
}
