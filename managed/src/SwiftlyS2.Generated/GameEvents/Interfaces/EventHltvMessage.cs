using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_message"
/// a HLTV message send by moderators
/// </summary>
public interface EventHltvMessage : ITypedGameEvent<EventHltvMessage> {

  static EventHltvMessage ITypedGameEvent<EventHltvMessage>.Wrap(IGameEvent accessor) => new EventHltvMessageImpl(accessor);

  static string ITypedGameEvent<EventHltvMessage>.GetName() => "hltv_message";

  static uint ITypedGameEvent<EventHltvMessage>.GetHash() => 0x0E93862Bu;
  /// <summary>
  /// type: string
  /// </summary>
  string Text { get; set; }

}
