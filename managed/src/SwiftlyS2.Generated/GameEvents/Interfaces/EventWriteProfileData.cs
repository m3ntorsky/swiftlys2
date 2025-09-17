using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "write_profile_data"
/// </summary>
public interface EventWriteProfileData : ITypedGameEvent<EventWriteProfileData> {

  static EventWriteProfileData ITypedGameEvent<EventWriteProfileData>.Wrap(IGameEvent accessor) => new EventWriteProfileDataImpl(accessor);

  static string ITypedGameEvent<EventWriteProfileData>.GetName() => "write_profile_data";

  static uint ITypedGameEvent<EventWriteProfileData>.GetHash() => 0x56158E97u;
}
