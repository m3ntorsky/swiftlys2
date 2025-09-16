using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_changename"
/// </summary>
internal class EventPlayerChangenameImpl : GameEvent<EventPlayerChangename>, EventPlayerChangename
{

  public EventPlayerChangenameImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // user ID on server
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // players old (current) name
  public string OldName
  { get => GetString("oldname"); set => SetString("oldname", value); }

  // players new name
  public string NewName
  { get => GetString("newname"); set => SetString("newname", value); }
}
