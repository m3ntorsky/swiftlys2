using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapInitialTransformDirectionToRotation : CParticleFunctionInitializer, IC_INIT_RemapInitialTransformDirectionToRotation {

  public C_INIT_RemapInitialTransformDirectionToRotation(nint handle) : base(handle) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x5301B477B3FDC289));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x5301B477E5729606));
  }
  public ref float OffsetRot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5301B477B414F849));
  }
  public ref int Component {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5301B477BFD0952C));
  }


}