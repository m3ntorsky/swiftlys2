using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmSpeedScaleBaseNode__CDefinition : CNmPassthroughNode::CDefinition, INmSpeedScaleBaseNode__CDefinition {

  public CNmSpeedScaleBaseNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x69CF028795E89F27));
  }
  public ref float DefaultInputValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69CF02875DFEC365));
  }


}