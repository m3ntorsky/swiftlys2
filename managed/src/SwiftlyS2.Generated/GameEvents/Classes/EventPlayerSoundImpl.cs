using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_sound"
/// </summary>
internal class EventPlayerSoundImpl : GameEvent<EventPlayerSound>, EventPlayerSound
{

  public EventPlayerSoundImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public int Radius
  { get => GetInt("radius"); set => SetInt("radius", value); }

  public float Duration
  { get => GetFloat("duration"); set => SetFloat("duration", value); }

  public bool Step
  { get => GetBool("step"); set => SetBool("step", value); }
}
