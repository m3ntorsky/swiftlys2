using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "local_player_team"
/// </summary>
internal class EventLocalPlayerTeamImpl : TypedGameEvent<EventLocalPlayerTeam>, EventLocalPlayerTeam
{

  public EventLocalPlayerTeamImpl(IGameEvent accessor) : base(accessor)
  {
  }
}
