using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderFlattenGrass : CParticleFunctionRenderer, IC_OP_RenderFlattenGrass {

  public C_OP_RenderFlattenGrass(nint handle) : base(handle) {
  }

  public C_OP_RenderFlattenGrass(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float FlattenStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81877FD959D69362));
  }
  public IParticleAttributeIndex_t StrengthFieldOverride {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x81877FD91996F4F8));
  }
  public ref float RadiusScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81877FD9A7A20159));
  }


}