using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointOrientationToCPVelocity : CParticleFunctionPreEmission, IC_OP_SetControlPointOrientationToCPVelocity {

  public C_OP_SetControlPointOrientationToCPVelocity(nint handle) : base(handle) {
  }

  public ref int CPInput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8FFC9885FB805736));
  }
  public ref int CPOutput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8FFC98852077C953));
  }


}