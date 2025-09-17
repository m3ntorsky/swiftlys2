using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "silencer_off"
/// </summary>
internal class EventSilencerOffImpl : TypedGameEvent<EventSilencerOff>, EventSilencerOff
{

  public EventSilencerOffImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
