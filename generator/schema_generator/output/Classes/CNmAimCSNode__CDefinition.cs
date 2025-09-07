using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmAimCSNode__CDefinition : CNmPassthroughNode::CDefinition, INmAimCSNode__CDefinition {

  public CNmAimCSNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmAimCSNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short VerticalAngleNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xE1CD14C20A1F17AD));
  }
  public ref short HorizontalAngleNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xE1CD14C28E2FD3DB));
  }
  public ref short EnabledNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xE1CD14C2F7CDF5E9));
  }
  public ref float BlendTimeSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE1CD14C26D3A08FC));
  }


}