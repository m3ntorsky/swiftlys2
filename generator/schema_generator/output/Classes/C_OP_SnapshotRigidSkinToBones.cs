using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SnapshotRigidSkinToBones : CParticleFunctionOperator, IC_OP_SnapshotRigidSkinToBones {

  public C_OP_SnapshotRigidSkinToBones(nint handle) : base(handle) {
  }

  public ref bool TransformNormals {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x208C05EB3C6BFD75));
  }
  public ref bool TransformRadii {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x208C05EB8183F664));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x208C05EB3F31A6BD));
  }


}