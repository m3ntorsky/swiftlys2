using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_begindefuse"
/// </summary>
internal class EventBombBegindefuseImpl : TypedGameEvent<EventBombBegindefuse>, EventBombBegindefuse
{


  // player who is defusing
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public bool HasKit
  { get => Accessor.GetBool("haskit"); set => Accessor.SetBool("haskit", value); }
}
