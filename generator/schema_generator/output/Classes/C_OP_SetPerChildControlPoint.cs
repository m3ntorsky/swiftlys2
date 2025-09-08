using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetPerChildControlPoint : CParticleFunctionOperator, IC_OP_SetPerChildControlPoint {

  public C_OP_SetPerChildControlPoint(nint handle) : base(handle) {
  }

  public ref int ChildGroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC456E2B9E3F3C965));
  }
  public ref int FirstControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC456E2B972117650));
  }
  public ref int NumControlPoints {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC456E2B9551EBC4F));
  }
  public IParticleCollectionFloatInput ParticleIncrement {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xC456E2B973AF63D0));
  }
  public IParticleCollectionFloatInput FirstSourcePoint {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xC456E2B99D7DC18E));
  }
  public ref bool SetOrientation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC456E2B9E1390E37));
  }
  public IParticleAttributeIndex_t OrientationField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xC456E2B9FFE45E9F));
  }
  public ref bool NumBasedOnParticleCount {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC456E2B9401CC5D0));
  }


}