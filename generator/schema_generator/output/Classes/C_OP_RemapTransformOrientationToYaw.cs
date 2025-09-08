using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapTransformOrientationToYaw : CParticleFunctionOperator, IC_OP_RemapTransformOrientationToYaw {

  public C_OP_RemapTransformOrientationToYaw(nint handle) : base(handle) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xA0DF014CB3FDC289));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA0DF014CE5729606));
  }
  public ref float RotOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA0DF014CD1EA9CDF));
  }
  public ref float SpinStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA0DF014C12520F26));
  }


}