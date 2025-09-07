using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapSDFGradientToVectorAttribute : CParticleFunctionOperator, IC_OP_RemapSDFGradientToVectorAttribute {

  public C_OP_RemapSDFGradientToVectorAttribute(nint handle) : base(handle) {
  }

  public C_OP_RemapSDFGradientToVectorAttribute(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x199621A9E5729606));
  }


}