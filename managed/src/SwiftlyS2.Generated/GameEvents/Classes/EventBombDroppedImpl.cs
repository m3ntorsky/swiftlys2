using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_dropped"
/// </summary>
internal class EventBombDroppedImpl : TypedGameEvent<EventBombDropped>, EventBombDropped
{

  public EventBombDroppedImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // player who dropped the bomb
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public int EntIndex
  { get => Accessor.GetInt32("entindex"); set => Accessor.SetInt32("entindex", value); }
}
