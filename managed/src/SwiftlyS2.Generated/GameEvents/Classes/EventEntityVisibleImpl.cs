using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "entity_visible"
/// </summary>
internal class EventEntityVisibleImpl : GameEvent<EventEntityVisible>, EventEntityVisible
{

  public EventEntityVisibleImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // The player who sees the entity
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // Entindex of the entity they see
  public int Subject
  { get => GetInt("subject"); set => SetInt("subject", value); }

  // Classname of the entity they see
  public string ClassName
  { get => GetString("classname"); set => SetString("classname", value); }

  // name of the entity they see
  public string EntityName
  { get => GetString("entityname"); set => SetString("entityname", value); }
}
