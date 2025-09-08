using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RopeSpringConstraint : CParticleFunctionConstraint, IC_OP_RopeSpringConstraint {

  public C_OP_RopeSpringConstraint(nint handle) : base(handle) {
  }

  public IParticleCollectionFloatInput RestLength {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2CF6156393AC4079));
  }
  public IParticleCollectionFloatInput MinDistance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2CF6156392BCAD06));
  }
  public IParticleCollectionFloatInput MaxDistance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2CF6156398893360));
  }
  public ref float AdjustmentScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2CF61563A29D34AE));
  }
  public IParticleCollectionFloatInput InitialRestingLength {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2CF61563FE9273C1));
  }


}