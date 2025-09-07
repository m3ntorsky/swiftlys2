using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapInitialVisibilityScalar : CParticleFunctionInitializer, IC_INIT_RemapInitialVisibilityScalar {

  public C_INIT_RemapInitialVisibilityScalar(nint handle) : base(handle) {
  }

  public C_INIT_RemapInitialVisibilityScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x6EA0C1DE5729606));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6EA0C1DE88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6EA0C1DD6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6EA0C1D5F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6EA0C1D51A0E8C4));
  }


}