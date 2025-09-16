using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "server_cvar"
/// a server console var has changed
/// </summary>
internal class EventServerCvarImpl : GameEvent<EventServerCvar>, EventServerCvar
{

  public EventServerCvarImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // cvar name, eg "mp_roundtime"
  public string CVarName
  { get => GetString("cvarname"); set => SetString("cvarname", value); }

  // new cvar value
  public string CVarValue
  { get => GetString("cvarvalue"); set => SetString("cvarvalue", value); }
}
