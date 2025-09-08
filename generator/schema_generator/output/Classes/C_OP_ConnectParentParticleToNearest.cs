using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ConnectParentParticleToNearest : CParticleFunctionOperator, IC_OP_ConnectParentParticleToNearest {

  public C_OP_ConnectParentParticleToNearest(nint handle) : base(handle) {
  }

  public ref int FirstControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9C608BD072117650));
  }
  public ref int SecondControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9C608BD04D8D2B44));
  }
  public ref bool UseRadius {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9C608BD0B7D98E6A));
  }
  public IParticleCollectionFloatInput RadiusScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x9C608BD0A7A20159));
  }
  public IParticleCollectionFloatInput ParentRadiusScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x9C608BD0CD77EF69));
  }


}