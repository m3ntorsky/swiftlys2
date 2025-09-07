using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleFunctionEmitter : CParticleFunction, IParticleFunctionEmitter {

  public CParticleFunctionEmitter(nint handle) : base(handle) {
  }

  public CParticleFunctionEmitter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int EmitterIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x72B3FA32117F91FF));
  }


}