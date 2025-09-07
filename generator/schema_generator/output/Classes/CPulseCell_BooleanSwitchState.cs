using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_BooleanSwitchState : CPulseCell_BaseState, IPulseCell_BooleanSwitchState {

  public CPulseCell_BooleanSwitchState(nint handle) : base(handle) {
  }

  public CPulseCell_BooleanSwitchState(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulseObservableBoolExpression_t Condition {
    get => new PulseObservableBoolExpression_t(_Handle + Schema.GetOffset(0xB0380EFD5F2A883E));
  }
  public IPulse_OutflowConnection SubGraph {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0xB0380EFD979BD817));
  }
  public IPulse_OutflowConnection WhenTrue {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0xB0380EFDB329ED61));
  }
  public IPulse_OutflowConnection WhenFalse {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0xB0380EFD4DD1A01C));
  }


}