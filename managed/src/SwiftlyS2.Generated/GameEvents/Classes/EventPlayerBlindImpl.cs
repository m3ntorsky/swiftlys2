using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_blind"
/// </summary>
internal class EventPlayerBlindImpl : TypedGameEvent<EventPlayerBlind>, EventPlayerBlind
{

  public EventPlayerBlindImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // user ID who threw the flash
  public int Attacker
  { get => Accessor.GetPlayerSlot("attacker"); set => Accessor.SetPlayerSlot("attacker", value); }

  // the flashbang going off
  public short EntityID
  { get => (short)Accessor.GetInt32("entityid"); set => Accessor.SetInt32("entityid", value); }

  public float BlindDuration
  { get => Accessor.GetFloat("blind_duration"); set => Accessor.SetFloat("blind_duration", value); }
}
