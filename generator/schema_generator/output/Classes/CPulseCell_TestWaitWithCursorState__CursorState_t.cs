using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_TestWaitWithCursorState__CursorState_t : SchemaClass, IPulseCell_TestWaitWithCursorState__CursorState_t {

  public CPulseCell_TestWaitWithCursorState__CursorState_t(nint handle) : base(handle) {
  }

  public CPulseCell_TestWaitWithCursorState__CursorState_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float WaitValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9C2318A48BB02277));
  }
  public ref bool FailOnCancel {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9C2318A4BEE5ED52));
  }


}