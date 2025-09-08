using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmCurrentSyncEventIDNode__CDefinition : CNmIDValueNode::CDefinition, INmCurrentSyncEventIDNode__CDefinition {

  public CNmCurrentSyncEventIDNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x792E5F1463F0228C));
  }


}