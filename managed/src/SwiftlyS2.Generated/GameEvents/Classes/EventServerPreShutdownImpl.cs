using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "server_pre_shutdown"
/// server is about to be shut down
/// </summary>
internal class EventServerPreShutdownImpl : TypedGameEvent<EventServerPreShutdown>, EventServerPreShutdown
{

  public EventServerPreShutdownImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // reason why server is about to be shut down
  public string Reason
  { get => Accessor.GetString("reason"); set => Accessor.SetString("reason", value); }
}
