using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "exit_buyzone"
/// </summary>
internal class EventExitBuyzoneImpl : TypedGameEvent<EventExitBuyzone>, EventExitBuyzone
{

  public EventExitBuyzoneImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public bool CanBuy
  { get => Accessor.GetBool("canbuy"); set => Accessor.SetBool("canbuy", value); }
}
