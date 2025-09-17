using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_changename"
/// </summary>
internal class EventPlayerChangenameImpl : TypedGameEvent<EventPlayerChangename>, EventPlayerChangename
{

  public EventPlayerChangenameImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // user ID on server
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // players old (current) name
  public string OldName
  { get => Accessor.GetString("oldname"); set => Accessor.SetString("oldname", value); }

  // players new name
  public string NewName
  { get => Accessor.GetString("newname"); set => Accessor.SetString("newname", value); }
}
