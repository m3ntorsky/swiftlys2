using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParamSpanUpdater : SchemaClass, IParamSpanUpdater {

  public CParamSpanUpdater(nint handle) : base(handle) {
  }

  public ref CUtlVector Spans {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA35886AC66213056));
  }


}