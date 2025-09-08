using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleFunctionInitializer : CParticleFunction, IParticleFunctionInitializer {

  public CParticleFunctionInitializer(nint handle) : base(handle) {
  }

  public ref int AssociatedEmitterIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA224E6D8D47B3DA5));
  }


}