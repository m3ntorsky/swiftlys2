using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FuseFunctionIndex_t : SchemaClass, IFuseFunctionIndex_t {

  public FuseFunctionIndex_t(nint handle) : base(handle) {
  }

  public ref ushort Value {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x48B825DFDCB0894A));
  }


}