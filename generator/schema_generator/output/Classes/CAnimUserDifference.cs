using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimUserDifference : SchemaClass, IAnimUserDifference {

  public CAnimUserDifference(nint handle) : base(handle) {
  }

  public CAnimUserDifference(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x8F174EDB4D8F5786));
  }
  public ref int Type {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8F174EDB18853D59));
  }


}