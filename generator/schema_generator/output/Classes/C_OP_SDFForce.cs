using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SDFForce : CParticleFunctionForce, IC_OP_SDFForce {

  public C_OP_SDFForce(nint handle) : base(handle) {
  }

  public C_OP_SDFForce(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float ForceScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x78CB679F4817F390));
  }


}