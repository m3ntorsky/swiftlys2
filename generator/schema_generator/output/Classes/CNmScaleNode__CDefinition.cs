using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmScaleNode__CDefinition : CNmPassthroughNode::CDefinition, INmScaleNode__CDefinition {

  public CNmScaleNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmScaleNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short MaskNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x5902F6B1216FA578));
  }
  public ref short EnableNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x5902F6B10C9DD729));
  }


}