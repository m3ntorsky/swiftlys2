using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hostname_changed"
/// </summary>
internal class EventHostnameChangedImpl : TypedGameEvent<EventHostnameChanged>, EventHostnameChanged
{


  public string Hostname
  { get => Accessor.GetString("hostname"); set => Accessor.SetString("hostname", value); }
}
