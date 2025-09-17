using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bullet_impact"
/// </summary>
internal class EventBulletImpactImpl : TypedGameEvent<EventBulletImpact>, EventBulletImpact
{

  public EventBulletImpactImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public float X
  { get => Accessor.GetFloat("x"); set => Accessor.SetFloat("x", value); }

  public float Y
  { get => Accessor.GetFloat("y"); set => Accessor.SetFloat("y", value); }

  public float Z
  { get => Accessor.GetFloat("z"); set => Accessor.SetFloat("z", value); }
}
