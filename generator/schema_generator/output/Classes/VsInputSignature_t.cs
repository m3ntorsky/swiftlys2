using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VsInputSignature_t : SchemaClass, IVsInputSignature_t {

  public VsInputSignature_t(nint handle) : base(handle) {
  }

  public ref CUtlVector Elems {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA7BF24E33F2FC92B));
  }
  public ref CUtlVector Depth_elems {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA7BF24E3C1AC112D));
  }


}