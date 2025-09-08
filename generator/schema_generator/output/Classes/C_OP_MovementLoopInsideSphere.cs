using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MovementLoopInsideSphere : CParticleFunctionOperator, IC_OP_MovementLoopInsideSphere {

  public C_OP_MovementLoopInsideSphere(nint handle) : base(handle) {
  }

  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7C19959FEB661472));
  }
  public IParticleCollectionFloatInput Distance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x7C19959F00DC4A68));
  }
  public IParticleCollectionVecInput Scale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x7C19959F5F596B51));
  }
  public IParticleAttributeIndex_t DistSqrAttr {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x7C19959F767818FE));
  }


}