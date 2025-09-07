using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MotionIndex : SchemaClass, IMotionIndex {

  public MotionIndex(nint handle) : base(handle) {
  }

  public MotionIndex(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort Group {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x5914302D0CD16308));
  }
  public ref ushort Motion {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x5914302DBB2E0DCB));
  }


}