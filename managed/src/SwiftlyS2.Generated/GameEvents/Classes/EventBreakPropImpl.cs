using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "break_prop"
/// </summary>
internal class EventBreakPropImpl : GameEvent<EventBreakProp>, EventBreakProp
{

  public EventBreakPropImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public int EntIndex
  { get => GetInt("entindex"); set => SetInt("entindex", value); }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public bool PlayerHeld
  { get => GetBool("player_held"); set => SetBool("player_held", value); }

  public bool PlayerThrown
  { get => GetBool("player_thrown"); set => SetBool("player_thrown", value); }

  public bool PlayerDropped
  { get => GetBool("player_dropped"); set => SetBool("player_dropped", value); }
}
