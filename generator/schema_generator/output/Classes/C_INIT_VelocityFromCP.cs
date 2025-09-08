using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_VelocityFromCP : CParticleFunctionInitializer, IC_INIT_VelocityFromCP {

  public C_INIT_VelocityFromCP(nint handle) : base(handle) {
  }

  public IParticleCollectionVecInput VelocityInput {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x1788D69A30C18956));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x1788D69A3A9ED669));
  }
  public ref float VelocityScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1788D69AE161DDAA));
  }
  public ref bool DirectionOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1788D69A7F403B2C));
  }


}