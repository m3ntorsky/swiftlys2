using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleFunctionRenderer : CParticleFunction, IParticleFunctionRenderer {

  public CParticleFunctionRenderer(nint handle) : base(handle) {
  }

  public CParticleFunctionRenderer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleVisibilityInputs VisibilityInputs {
    get => new CParticleVisibilityInputs(_Handle + Schema.GetOffset(0xAE332DA3CF8264F8));
  }
  public ref bool CannotBeRefracted {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAE332DA3CC78C4FB));
  }
  public ref bool SkipRenderingOnMobile {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAE332DA33F34EA75));
  }


}