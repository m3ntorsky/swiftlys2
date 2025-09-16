using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "mb_input_lock_success"
/// </summary>
public interface EventMbInputLockSuccess : IGameEvent<EventMbInputLockSuccess> {

  static EventMbInputLockSuccess IGameEvent<EventMbInputLockSuccess>.FromAllocated(nint ptr) => new EventMbInputLockSuccessImpl(ptr, true);

  static EventMbInputLockSuccess IGameEvent<EventMbInputLockSuccess>.FromExternal(nint ptr) => new EventMbInputLockSuccessImpl(ptr, false);

  static string IGameEvent<EventMbInputLockSuccess>.GetName() => "mb_input_lock_success";

  static uint IGameEvent<EventMbInputLockSuccess>.GetHash() => 0xEB082439u;
}
