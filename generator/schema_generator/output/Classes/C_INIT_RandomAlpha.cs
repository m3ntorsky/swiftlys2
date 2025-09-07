using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomAlpha : CParticleFunctionInitializer, IC_INIT_RandomAlpha {

  public C_INIT_RandomAlpha(nint handle) : base(handle) {
  }

  public C_INIT_RandomAlpha(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x3D7FD5BE5729606));
  }
  public ref int AlphaMin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D7FD5BD7670531));
  }
  public ref int AlphaMax {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D7FD5BE97AA93F));
  }
  public ref float AlphaRandExponent {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3D7FD5BA2C243B5));
  }


}