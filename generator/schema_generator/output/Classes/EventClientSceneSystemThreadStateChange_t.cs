using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientSceneSystemThreadStateChange_t : SchemaClass, IEventClientSceneSystemThreadStateChange_t {

  public EventClientSceneSystemThreadStateChange_t(nint handle) : base(handle) {
  }

  public EventClientSceneSystemThreadStateChange_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool ThreadsActive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28053E1174AC2EF0));
  }


}