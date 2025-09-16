using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_blind"
/// </summary>
internal class EventPlayerBlindImpl : GameEvent<EventPlayerBlind>, EventPlayerBlind
{

  public EventPlayerBlindImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // user ID who threw the flash
  public int Attacker
  { get => GetPlayerSlot("attacker"); set => SetPlayerSlot("attacker", value); }

  // the flashbang going off
  public short EntityID
  { get => (short)GetInt("entityid"); set => SetInt("entityid", value); }

  public float BlindDuration
  { get => GetFloat("blind_duration"); set => SetFloat("blind_duration", value); }
}
