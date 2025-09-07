using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetChildControlPoints : CParticleFunctionOperator, IC_OP_SetChildControlPoints {

  public C_OP_SetChildControlPoints(nint handle) : base(handle) {
  }

  public C_OP_SetChildControlPoints(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ChildGroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x42125413E3F3C965));
  }
  public ref int FirstControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4212541372117650));
  }
  public ref int NumControlPoints {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x42125413551EBC4F));
  }
  public IParticleCollectionFloatInput FirstSourcePoint {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x421254139D7DC18E));
  }
  public ref bool Reverse {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42125413EA4E22E5));
  }
  public ref bool SetOrientation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42125413E1390E37));
  }
  public ref ParticleOrientationType_t Orientation {
    get => ref _Handle.AsRef<ParticleOrientationType_t>(Schema.GetOffset(0x42125413B02B656D));
  }


}