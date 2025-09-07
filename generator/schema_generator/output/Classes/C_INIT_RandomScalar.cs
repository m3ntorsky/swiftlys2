using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomScalar : CParticleFunctionInitializer, IC_INIT_RandomScalar {

  public C_INIT_RandomScalar(nint handle) : base(handle) {
  }

  public C_INIT_RandomScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x76660B0D3B1A5649));
  }
  public ref float Max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x76660B0D2D06B887));
  }
  public ref float Exponent {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x76660B0D20A7BCBC));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x76660B0DE5729606));
  }


}