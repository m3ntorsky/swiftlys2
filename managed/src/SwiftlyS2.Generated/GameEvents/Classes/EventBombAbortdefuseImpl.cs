using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_abortdefuse"
/// </summary>
internal class EventBombAbortdefuseImpl : TypedGameEvent<EventBombAbortdefuse>, EventBombAbortdefuse
{


  // player who was defusing
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
