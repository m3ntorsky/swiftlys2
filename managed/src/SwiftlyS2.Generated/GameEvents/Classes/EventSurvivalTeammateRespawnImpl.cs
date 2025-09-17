using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "survival_teammate_respawn"
/// </summary>
internal class EventSurvivalTeammateRespawnImpl : TypedGameEvent<EventSurvivalTeammateRespawn>, EventSurvivalTeammateRespawn
{

  public EventSurvivalTeammateRespawnImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
