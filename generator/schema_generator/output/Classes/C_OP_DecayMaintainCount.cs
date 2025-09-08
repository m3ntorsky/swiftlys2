using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DecayMaintainCount : CParticleFunctionOperator, IC_OP_DecayMaintainCount {

  public C_OP_DecayMaintainCount(nint handle) : base(handle) {
  }

  public ref int ParticlesToMaintain {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x168E27F3537AE378));
  }
  public ref float DecayDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x168E27F38D6DD836));
  }
  public ref int SnapshotControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x168E27F3192638EC));
  }
  public ref bool LifespanDecay {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x168E27F39642CC6B));
  }
  public IParticleCollectionFloatInput Scale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x168E27F3B731A42F));
  }
  public ref bool KillNewest {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x168E27F3B8EA2EC7));
  }


}