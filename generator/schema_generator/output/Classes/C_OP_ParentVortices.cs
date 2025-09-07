using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ParentVortices : CParticleFunctionForce, IC_OP_ParentVortices {

  public C_OP_ParentVortices(nint handle) : base(handle) {
  }

  public C_OP_ParentVortices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float ForceScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBB2B6F884817F390));
  }
  public ref Vector TwistAxis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xBB2B6F8808970741));
  }
  public ref bool FlipBasedOnYaw {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBB2B6F88BCFD5843));
  }


}