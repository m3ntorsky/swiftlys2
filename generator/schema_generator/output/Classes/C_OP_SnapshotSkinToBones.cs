using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SnapshotSkinToBones : CParticleFunctionOperator, IC_OP_SnapshotSkinToBones {

  public C_OP_SnapshotSkinToBones(nint handle) : base(handle) {
  }

  public C_OP_SnapshotSkinToBones(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool TransformNormals {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCA48FCF83C6BFD75));
  }
  public ref bool TransformRadii {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCA48FCF88183F664));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xCA48FCF83F31A6BD));
  }
  public ref float LifeTimeFadeStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCA48FCF895A2845A));
  }
  public ref float LifeTimeFadeEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCA48FCF8222841EF));
  }
  public ref float JumpThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCA48FCF8B6BB1AD6));
  }
  public ref float PrevPosScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCA48FCF846CED122));
  }


}