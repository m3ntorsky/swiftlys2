using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ragdollelement_t : SchemaClass, Iragdollelement_t {

  public ragdollelement_t(nint handle) : base(handle) {
  }

  public ragdollelement_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector OriginParentSpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6DFDA0AB476AA8AB));
  }
  public ref int ParentIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6DFDA0ABFE49C863));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6DFDA0AB5ACFC08D));
  }
  public ref int Height {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6DFDA0ABCAB61C56));
  }


}