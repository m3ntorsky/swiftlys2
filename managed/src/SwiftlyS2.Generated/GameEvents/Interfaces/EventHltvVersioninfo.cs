using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_versioninfo"
/// </summary>
public interface EventHltvVersioninfo : ITypedGameEvent<EventHltvVersioninfo> {

  static EventHltvVersioninfo ITypedGameEvent<EventHltvVersioninfo>.Create() => new EventHltvVersioninfoImpl();

  static string ITypedGameEvent<EventHltvVersioninfo>.GetName() => "hltv_versioninfo";

  static uint ITypedGameEvent<EventHltvVersioninfo>.GetHash() => 0xAB9E0AFCu;
  /// <summary>
  /// type: long
  /// </summary>
  int Version { get; set; }

}
