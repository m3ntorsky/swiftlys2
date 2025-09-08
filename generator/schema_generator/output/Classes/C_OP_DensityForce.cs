using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DensityForce : CParticleFunctionForce, IC_OP_DensityForce {

  public C_OP_DensityForce(nint handle) : base(handle) {
  }

  public ref float RadiusScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7846D656A7A20159));
  }
  public ref float ForceScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7846D6564817F390));
  }
  public ref float TargetDensity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7846D656157E0796));
  }


}