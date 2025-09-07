using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapVisibilityScalar : CParticleFunctionOperator, IC_OP_RemapVisibilityScalar {

  public C_OP_RemapVisibilityScalar(nint handle) : base(handle) {
  }

  public C_OP_RemapVisibilityScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x2215F0FEAE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x2215F0FEE5729606));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2215F0FEE88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2215F0FED6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2215F0FE5F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2215F0FE51A0E8C4));
  }
  public ref float RadiusScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2215F0FEA7A20159));
  }


}