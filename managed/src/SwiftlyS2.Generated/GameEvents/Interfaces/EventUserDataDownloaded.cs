using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "user_data_downloaded"
/// fired when achievements/stats are downloaded from Steam or XBox Live
/// </summary>
public interface EventUserDataDownloaded : ITypedGameEvent<EventUserDataDownloaded> {

  static EventUserDataDownloaded ITypedGameEvent<EventUserDataDownloaded>.Create() => new EventUserDataDownloadedImpl();

  static string ITypedGameEvent<EventUserDataDownloaded>.GetName() => "user_data_downloaded";

  static uint ITypedGameEvent<EventUserDataDownloaded>.GetHash() => 0xA7AE5F51u;
}
