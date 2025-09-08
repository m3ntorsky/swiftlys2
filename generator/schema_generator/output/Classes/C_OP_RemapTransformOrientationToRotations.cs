using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapTransformOrientationToRotations : CParticleFunctionOperator, IC_OP_RemapTransformOrientationToRotations {

  public C_OP_RemapTransformOrientationToRotations(nint handle) : base(handle) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x73EBC1F8B3FDC289));
  }
  public ref Vector Rotation {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x73EBC1F81992E6BF));
  }
  public ref bool UseQuat {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73EBC1F843F0D4DB));
  }
  public ref bool WriteNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73EBC1F8C2EF44FF));
  }


}