using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_status"
/// general HLTV status
/// </summary>
internal class EventHltvStatusImpl : GameEvent<EventHltvStatus>, EventHltvStatus
{

  public EventHltvStatusImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // number of HLTV spectators
  public int Clients
  { get => GetInt("clients"); set => SetInt("clients", value); }

  // number of HLTV slots
  public int Slots
  { get => GetInt("slots"); set => SetInt("slots", value); }

  // number of HLTV proxies
  public short Proxies
  { get => (short)GetInt("proxies"); set => SetInt("proxies", value); }

  // disptach master IP:port
  public string Master
  { get => GetString("master"); set => SetString("master", value); }
}
