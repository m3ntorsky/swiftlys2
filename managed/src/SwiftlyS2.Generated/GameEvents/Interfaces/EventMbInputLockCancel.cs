using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "mb_input_lock_cancel"
/// </summary>
public interface EventMbInputLockCancel : ITypedGameEvent<EventMbInputLockCancel> {

  static EventMbInputLockCancel ITypedGameEvent<EventMbInputLockCancel>.Create() => new EventMbInputLockCancelImpl();

  static string ITypedGameEvent<EventMbInputLockCancel>.GetName() => "mb_input_lock_cancel";

  static uint ITypedGameEvent<EventMbInputLockCancel>.GetHash() => 0x79A46A94u;
}
