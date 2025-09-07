using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmRootMotionEvent : CNmEvent, INmRootMotionEvent {

  public CNmRootMotionEvent(nint handle) : base(handle) {
  }

  public CNmRootMotionEvent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float BlendTimeSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8BA908676D3A08FC));
  }


}