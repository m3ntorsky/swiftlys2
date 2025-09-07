using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventFrameBoundary_t : SchemaClass, IEventFrameBoundary_t {

  public EventFrameBoundary_t(nint handle) : base(handle) {
  }

  public EventFrameBoundary_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float FrameTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDFF6C21659DF875));
  }


}