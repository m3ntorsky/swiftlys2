using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatRemapNode__RemapRange_t : SchemaClass, INmFloatRemapNode__RemapRange_t {

  public CNmFloatRemapNode__RemapRange_t(nint handle) : base(handle) {
  }

  public CNmFloatRemapNode__RemapRange_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Begin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C6A3517504C130));
  }
  public ref float End {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C6A3519616A27C));
  }


}