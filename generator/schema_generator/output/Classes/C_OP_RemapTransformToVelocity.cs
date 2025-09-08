using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapTransformToVelocity : CParticleFunctionOperator, IC_OP_RemapTransformToVelocity {

  public C_OP_RemapTransformToVelocity(nint handle) : base(handle) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xC1A2CC64B3FDC289));
  }


}