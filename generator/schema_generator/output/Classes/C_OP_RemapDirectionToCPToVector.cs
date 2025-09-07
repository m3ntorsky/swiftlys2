using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapDirectionToCPToVector : CParticleFunctionOperator, IC_OP_RemapDirectionToCPToVector {

  public C_OP_RemapDirectionToCPToVector(nint handle) : base(handle) {
  }

  public C_OP_RemapDirectionToCPToVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x80443C5BEB661472));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x80443C5BE5729606));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x80443C5BB731A42F));
  }
  public ref float OffsetRot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x80443C5BB414F849));
  }
  public ref Vector OffsetAxis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x80443C5BFAB4918F));
  }
  public ref bool Normalize {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x80443C5B48BC424C));
  }
  public IParticleAttributeIndex_t FieldStrength {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x80443C5BDBA3663E));
  }


}