using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmCurrentSyncEventNode__CDefinition : CNmFloatValueNode::CDefinition, INmCurrentSyncEventNode__CDefinition {

  public CNmCurrentSyncEventNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x1F6A7BCB63F0228C));
  }
  public ref CNmCurrentSyncEventNode::InfoType_t InfoType {
    get => ref _Handle.AsRef<CNmCurrentSyncEventNode::InfoType_t>(Schema.GetOffset(0x1F6A7BCBCE6BA20D));
  }


}