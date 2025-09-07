using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParamSpanUpdater : SchemaClass, IParamSpanUpdater {

  public CParamSpanUpdater(nint handle) : base(handle) {
  }

  public CParamSpanUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< ParamSpan_t > Spans {
    get => ref _Handle.AsRef<CUtlVector< ParamSpan_t >>(Schema.GetOffset(0xA35886AC66213056));
  }


}