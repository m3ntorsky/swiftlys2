using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomVectorComponent : CParticleFunctionInitializer, IC_INIT_RandomVectorComponent {

  public C_INIT_RandomVectorComponent(nint handle) : base(handle) {
  }

  public C_INIT_RandomVectorComponent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6D670313B1A5649));
  }
  public ref float Max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6D670312D06B887));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD6D67031E5729606));
  }
  public ref int Component {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD6D67031BFD0952C));
  }


}