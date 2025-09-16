using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_versioninfo"
/// </summary>
public interface EventHltvVersioninfo : IGameEvent<EventHltvVersioninfo> {

  static EventHltvVersioninfo IGameEvent<EventHltvVersioninfo>.FromAllocated(nint ptr) => new EventHltvVersioninfoImpl(ptr, true);

  static EventHltvVersioninfo IGameEvent<EventHltvVersioninfo>.FromExternal(nint ptr) => new EventHltvVersioninfoImpl(ptr, false);

  static string IGameEvent<EventHltvVersioninfo>.GetName() => "hltv_versioninfo";

  static uint IGameEvent<EventHltvVersioninfo>.GetHash() => 0xAB9E0AFCu;
  /// <summary>
  /// type: long
  /// </summary>
  int Version { get; set; }

}
