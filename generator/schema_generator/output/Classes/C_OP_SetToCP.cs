using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetToCP : CParticleFunctionOperator, IC_OP_SetToCP {

  public C_OP_SetToCP(nint handle) : base(handle) {
  }

  public C_OP_SetToCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF80ACA353F31A6BD));
  }
  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xF80ACA35BD25CC2A));
  }
  public ref bool OffsetLocal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF80ACA35F07D31C1));
  }


}