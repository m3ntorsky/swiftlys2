using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "break_prop"
/// </summary>
internal class EventBreakPropImpl : TypedGameEvent<EventBreakProp>, EventBreakProp
{

  public EventBreakPropImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public int EntIndex
  { get => Accessor.GetInt32("entindex"); set => Accessor.SetInt32("entindex", value); }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public bool PlayerHeld
  { get => Accessor.GetBool("player_held"); set => Accessor.SetBool("player_held", value); }

  public bool PlayerThrown
  { get => Accessor.GetBool("player_thrown"); set => Accessor.SetBool("player_thrown", value); }

  public bool PlayerDropped
  { get => Accessor.GetBool("player_dropped"); set => Accessor.SetBool("player_dropped", value); }
}
