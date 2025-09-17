using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_falldamage"
/// </summary>
internal class EventPlayerFalldamageImpl : TypedGameEvent<EventPlayerFalldamage>, EventPlayerFalldamage
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public float Damage
  { get => Accessor.GetFloat("damage"); set => Accessor.SetFloat("damage", value); }
}
