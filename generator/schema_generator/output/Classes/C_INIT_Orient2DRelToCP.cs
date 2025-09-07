using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_Orient2DRelToCP : CParticleFunctionInitializer, IC_INIT_Orient2DRelToCP {

  public C_INIT_Orient2DRelToCP(nint handle) : base(handle) {
  }

  public C_INIT_Orient2DRelToCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4B55AD02EB661472));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4B55AD02E5729606));
  }
  public ref float RotOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4B55AD02D1EA9CDF));
  }


}