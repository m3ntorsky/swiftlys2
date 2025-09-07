using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapDensityGradientToVectorAttribute : CParticleFunctionOperator, IC_OP_RemapDensityGradientToVectorAttribute {

  public C_OP_RemapDensityGradientToVectorAttribute(nint handle) : base(handle) {
  }

  public C_OP_RemapDensityGradientToVectorAttribute(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float RadiusScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB9D06F88A7A20159));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xB9D06F88E5729606));
  }


}