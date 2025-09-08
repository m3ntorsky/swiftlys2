using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderScreenVelocityRotate : CParticleFunctionRenderer, IC_OP_RenderScreenVelocityRotate {

  public C_OP_RenderScreenVelocityRotate(nint handle) : base(handle) {
  }

  public ref float RotateRateDegrees {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6288600D11A21BC7));
  }
  public ref float ForwardDegrees {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6288600D44D44C45));
  }


}