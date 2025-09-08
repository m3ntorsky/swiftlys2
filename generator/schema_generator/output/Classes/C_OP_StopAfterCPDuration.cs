using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_StopAfterCPDuration : CParticleFunctionPreEmission, IC_OP_StopAfterCPDuration {

  public C_OP_StopAfterCPDuration(nint handle) : base(handle) {
  }

  public IParticleCollectionFloatInput Duration {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xFC2AFAC6BC5E3BAB));
  }
  public ref bool DestroyImmediately {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFC2AFAC675F43101));
  }
  public ref bool PlayEndCap {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFC2AFAC6A7AB4A38));
  }


}