using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "server_shutdown"
/// server shut down
/// </summary>
internal class EventServerShutdownImpl : TypedGameEvent<EventServerShutdown>, EventServerShutdown
{

  public EventServerShutdownImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // reason why server was shut down
  public string Reason
  { get => Accessor.GetString("reason"); set => Accessor.SetString("reason", value); }
}
