using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_radio"
/// </summary>
internal class EventPlayerRadioImpl : GameEvent<EventPlayerRadio>, EventPlayerRadio
{

  public EventPlayerRadioImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public short Slot
  { get => (short)GetInt("slot"); set => SetInt("slot", value); }
}
