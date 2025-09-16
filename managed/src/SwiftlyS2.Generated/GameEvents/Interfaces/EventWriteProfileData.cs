using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "write_profile_data"
/// </summary>
public interface EventWriteProfileData : IGameEvent<EventWriteProfileData> {

  static EventWriteProfileData IGameEvent<EventWriteProfileData>.FromAllocated(nint ptr) => new EventWriteProfileDataImpl(ptr, true);

  static EventWriteProfileData IGameEvent<EventWriteProfileData>.FromExternal(nint ptr) => new EventWriteProfileDataImpl(ptr, false);

  static string IGameEvent<EventWriteProfileData>.GetName() => "write_profile_data";

  static uint IGameEvent<EventWriteProfileData>.GetHash() => 0x56158E97u;
}
