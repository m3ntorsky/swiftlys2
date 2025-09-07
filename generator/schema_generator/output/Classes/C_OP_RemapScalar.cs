using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapScalar : CParticleFunctionOperator, IC_OP_RemapScalar {

  public C_OP_RemapScalar(nint handle) : base(handle) {
  }

  public C_OP_RemapScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x580A448EAE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x580A448EE5729606));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x580A448EE88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x580A448ED6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x580A448E5F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x580A448E51A0E8C4));
  }
  public ref bool OldCode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x580A448EFB4CA66B));
  }


}