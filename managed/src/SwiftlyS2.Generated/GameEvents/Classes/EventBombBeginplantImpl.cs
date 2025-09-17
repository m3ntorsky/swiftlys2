using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_beginplant"
/// </summary>
internal class EventBombBeginplantImpl : TypedGameEvent<EventBombBeginplant>, EventBombBeginplant
{

  public EventBombBeginplantImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // player who is planting the bomb
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // bombsite index
  public short Site
  { get => (short)Accessor.GetInt32("site"); set => Accessor.SetInt32("site", value); }
}
