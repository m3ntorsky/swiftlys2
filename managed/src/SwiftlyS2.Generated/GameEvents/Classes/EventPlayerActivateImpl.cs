using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_activate"
/// </summary>
internal class EventPlayerActivateImpl : TypedGameEvent<EventPlayerActivate>, EventPlayerActivate
{

  public EventPlayerActivateImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // user ID on server
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
