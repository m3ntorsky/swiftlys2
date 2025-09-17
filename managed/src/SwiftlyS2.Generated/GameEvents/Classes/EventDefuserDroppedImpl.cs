using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "defuser_dropped"
/// </summary>
internal class EventDefuserDroppedImpl : TypedGameEvent<EventDefuserDropped>, EventDefuserDropped
{

  public EventDefuserDroppedImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // defuser's entity ID
  public int EntityID
  { get => Accessor.GetInt32("entityid"); set => Accessor.SetInt32("entityid", value); }
}
