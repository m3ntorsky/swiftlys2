using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LerpToInitialPosition : CParticleFunctionOperator, IC_OP_LerpToInitialPosition {

  public C_OP_LerpToInitialPosition(nint handle) : base(handle) {
  }

  public C_OP_LerpToInitialPosition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x56175BC3F31A6BD));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x56175BCCF55B987));
  }
  public IParticleAttributeIndex_t CacheField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x56175BCB3696EEB));
  }
  public IParticleCollectionFloatInput Scale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x56175BCB731A42F));
  }
  public IParticleCollectionVecInput Scale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x56175BC5F596B51));
  }


}