using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DragRelativeToPlane : CParticleFunctionOperator, IC_OP_DragRelativeToPlane {

  public C_OP_DragRelativeToPlane(nint handle) : base(handle) {
  }

  public C_OP_DragRelativeToPlane(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput DragAtPlane {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x9D049848176259A2));
  }
  public IParticleCollectionFloatInput Falloff {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x9D049848FA143DCB));
  }
  public ref bool Directional {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9D0498484C2A43E7));
  }
  public IParticleCollectionVecInput PlaneNormal {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x9D04984821103682));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9D0498483F31A6BD));
  }


}