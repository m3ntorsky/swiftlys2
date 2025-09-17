using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "firstbombs_incoming_warning"
/// </summary>
internal class EventFirstbombsIncomingWarningImpl : TypedGameEvent<EventFirstbombsIncomingWarning>, EventFirstbombsIncomingWarning
{

  public EventFirstbombsIncomingWarningImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public bool Global
  { get => Accessor.GetBool("global"); set => Accessor.SetBool("global", value); }
}
