using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_chat"
/// a HLTV chat msg sent by spectators
/// </summary>
public interface EventHltvChat : IGameEvent<EventHltvChat> {

  static EventHltvChat IGameEvent<EventHltvChat>.FromAllocated(nint ptr) => new EventHltvChatImpl(ptr, true);

  static EventHltvChat IGameEvent<EventHltvChat>.FromExternal(nint ptr) => new EventHltvChatImpl(ptr, false);

  static string IGameEvent<EventHltvChat>.GetName() => "hltv_chat";

  static uint IGameEvent<EventHltvChat>.GetHash() => 0x91E5A35Au;
  /// <summary>
  /// type: string
  /// </summary>
  string Text { get; set; }

  /// <summary>
  /// steam id
  /// <br/>
  /// type: uint64
  /// </summary>
  ulong SteamID { get; set; }

}
