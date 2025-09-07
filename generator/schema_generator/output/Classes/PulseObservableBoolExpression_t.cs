using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseObservableBoolExpression_t : SchemaClass, IPulseObservableBoolExpression_t {

  public PulseObservableBoolExpression_t(nint handle) : base(handle) {
  }

  public PulseObservableBoolExpression_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulse_OutflowConnection EvaluateConnection {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0x420AB396176904EE));
  }
  public ref CUtlVector< PulseRuntimeVarIndex_t > DependentObservableVars {
    get => ref _Handle.AsRef<CUtlVector< PulseRuntimeVarIndex_t >>(Schema.GetOffset(0x420AB396C3F55B8B));
  }
  public ref CUtlVector< PulseRuntimeBlackboardReferenceIndex_t > DependentObservableBlackboardReferences {
    get => ref _Handle.AsRef<CUtlVector< PulseRuntimeBlackboardReferenceIndex_t >>(Schema.GetOffset(0x420AB3961EE1483A));
  }


}