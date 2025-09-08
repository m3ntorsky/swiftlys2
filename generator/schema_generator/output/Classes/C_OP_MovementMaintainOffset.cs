using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MovementMaintainOffset : CParticleFunctionOperator, IC_OP_MovementMaintainOffset {

  public C_OP_MovementMaintainOffset(nint handle) : base(handle) {
  }

  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD9B3E796BD25CC2A));
  }
  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD9B3E796EB661472));
  }
  public ref bool RadiusScale {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD9B3E796BBCB728B));
  }


}