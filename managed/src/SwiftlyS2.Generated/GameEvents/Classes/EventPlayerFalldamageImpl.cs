using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_falldamage"
/// </summary>
internal class EventPlayerFalldamageImpl : GameEvent<EventPlayerFalldamage>, EventPlayerFalldamage
{

  public EventPlayerFalldamageImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public float Damage
  { get => GetFloat("damage"); set => SetFloat("damage", value); }
}
