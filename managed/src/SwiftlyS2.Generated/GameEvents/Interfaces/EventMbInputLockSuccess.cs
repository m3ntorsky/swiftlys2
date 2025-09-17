using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "mb_input_lock_success"
/// </summary>
public interface EventMbInputLockSuccess : ITypedGameEvent<EventMbInputLockSuccess> {

  static EventMbInputLockSuccess ITypedGameEvent<EventMbInputLockSuccess>.Wrap(IGameEvent accessor) => new EventMbInputLockSuccessImpl(accessor);

  static string ITypedGameEvent<EventMbInputLockSuccess>.GetName() => "mb_input_lock_success";

  static uint ITypedGameEvent<EventMbInputLockSuccess>.GetHash() => 0xEB082439u;
}
