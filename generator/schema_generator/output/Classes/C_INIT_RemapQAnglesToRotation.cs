using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapQAnglesToRotation : CParticleFunctionInitializer, IC_INIT_RemapQAnglesToRotation {

  public C_INIT_RemapQAnglesToRotation(nint handle) : base(handle) {
  }

  public C_INIT_RemapQAnglesToRotation(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xD24C8C15B3FDC289));
  }


}