using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_TimeVaryingForce : CParticleFunctionForce, IC_OP_TimeVaryingForce {

  public C_OP_TimeVaryingForce(nint handle) : base(handle) {
  }

  public C_OP_TimeVaryingForce(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float StartLerpTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAC89FC47C1D0DC21));
  }
  public ref Vector StartingForce {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xAC89FC478FA47818));
  }
  public ref float EndLerpTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAC89FC47AA182894));
  }
  public ref Vector EndingForce {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xAC89FC47CEB5307D));
  }


}