using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeFollowNode_t : SchemaClass, IFeFollowNode_t {

  public FeFollowNode_t(nint handle) : base(handle) {
  }

  public ref ushort ParentNode {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x8BE908126CBBA7F9));
  }
  public ref ushort ChildNode {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x8BE9081292A8E0E9));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8BE90812CFFC66CB));
  }


}