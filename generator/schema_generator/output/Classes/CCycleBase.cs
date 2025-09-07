using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCycleBase : SchemaClass, ICycleBase {

  public CCycleBase(nint handle) : base(handle) {
  }

  public CCycleBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Cycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8FBE16990C77829F));
  }


}