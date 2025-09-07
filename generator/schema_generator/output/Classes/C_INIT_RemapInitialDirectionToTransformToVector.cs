using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapInitialDirectionToTransformToVector : CParticleFunctionInitializer, IC_INIT_RemapInitialDirectionToTransformToVector {

  public C_INIT_RemapInitialDirectionToTransformToVector(nint handle) : base(handle) {
  }

  public C_INIT_RemapInitialDirectionToTransformToVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xB8FCDAFFB3FDC289));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xB8FCDAFFE5729606));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8FCDAFFB731A42F));
  }
  public ref float OffsetRot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8FCDAFFB414F849));
  }
  public ref Vector OffsetAxis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB8FCDAFFFAB4918F));
  }
  public ref bool Normalize {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB8FCDAFF48BC424C));
  }


}