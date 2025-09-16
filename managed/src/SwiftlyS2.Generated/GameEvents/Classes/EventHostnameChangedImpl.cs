using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hostname_changed"
/// </summary>
internal class EventHostnameChangedImpl : GameEvent<EventHostnameChanged>, EventHostnameChanged
{

  public EventHostnameChangedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string Hostname
  { get => GetString("hostname"); set => SetString("hostname", value); }
}
