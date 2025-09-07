using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointFromObjectScale : CParticleFunctionPreEmission, IC_OP_SetControlPointFromObjectScale {

  public C_OP_SetControlPointFromObjectScale(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointFromObjectScale(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CPInput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB0DB8599FB805736));
  }
  public ref int CPOutput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB0DB85992077C953));
  }


}