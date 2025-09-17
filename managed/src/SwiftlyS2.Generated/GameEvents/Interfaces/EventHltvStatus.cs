using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_status"
/// general HLTV status
/// </summary>
public interface EventHltvStatus : ITypedGameEvent<EventHltvStatus> {

  static EventHltvStatus ITypedGameEvent<EventHltvStatus>.Wrap(IGameEvent accessor) => new EventHltvStatusImpl(accessor);

  static string ITypedGameEvent<EventHltvStatus>.GetName() => "hltv_status";

  static uint ITypedGameEvent<EventHltvStatus>.GetHash() => 0x81C8CF76u;
  /// <summary>
  /// number of HLTV spectators
  /// <br/>
  /// type: long
  /// </summary>
  int Clients { get; set; }

  /// <summary>
  /// number of HLTV slots
  /// <br/>
  /// type: long
  /// </summary>
  int Slots { get; set; }

  /// <summary>
  /// number of HLTV proxies
  /// <br/>
  /// type: short
  /// </summary>
  short Proxies { get; set; }

  /// <summary>
  /// disptach master IP:port
  /// <br/>
  /// type: string
  /// </summary>
  string Master { get; set; }

}
