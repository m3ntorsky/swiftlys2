using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_sound"
/// </summary>
internal class EventPlayerSoundImpl : TypedGameEvent<EventPlayerSound>, EventPlayerSound
{

  public EventPlayerSoundImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public int Radius
  { get => Accessor.GetInt32("radius"); set => Accessor.SetInt32("radius", value); }

  public float Duration
  { get => Accessor.GetFloat("duration"); set => Accessor.SetFloat("duration", value); }

  public bool Step
  { get => Accessor.GetBool("step"); set => Accessor.SetBool("step", value); }
}
