using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SDFConstraint : CParticleFunctionConstraint, IC_OP_SDFConstraint {

  public C_OP_SDFConstraint(nint handle) : base(handle) {
  }

  public IParticleCollectionFloatInput MinDist {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x3662556B5219494D));
  }
  public IParticleCollectionFloatInput MaxDist {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x3662556BEFFD23F7));
  }
  public ref int MaxIterations {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3662556B88B1243D));
  }


}