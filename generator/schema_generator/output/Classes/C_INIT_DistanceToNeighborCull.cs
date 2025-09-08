using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_DistanceToNeighborCull : CParticleFunctionInitializer, IC_INIT_DistanceToNeighborCull {

  public C_INIT_DistanceToNeighborCull(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput Distance {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x9ADFD8BA00DC4A68));
  }
  public ref bool IncludeRadii {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9ADFD8BAC86BFED0));
  }
  public IPerParticleFloatInput LifespanOverlap {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x9ADFD8BAB495428C));
  }


}