using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_radio"
/// </summary>
internal class EventPlayerRadioImpl : TypedGameEvent<EventPlayerRadio>, EventPlayerRadio
{

  public EventPlayerRadioImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public short Slot
  { get => (short)Accessor.GetInt32("slot"); set => Accessor.SetInt32("slot", value); }
}
