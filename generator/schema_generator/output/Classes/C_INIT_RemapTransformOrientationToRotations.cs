using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapTransformOrientationToRotations : CParticleFunctionInitializer, IC_INIT_RemapTransformOrientationToRotations {

  public C_INIT_RemapTransformOrientationToRotations(nint handle) : base(handle) {
  }

  public C_INIT_RemapTransformOrientationToRotations(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x51F07293B3FDC289));
  }
  public ref Vector Rotation {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x51F072931992E6BF));
  }
  public ref bool UseQuat {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x51F0729343F0D4DB));
  }
  public ref bool WriteNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x51F07293C2EF44FF));
  }


}