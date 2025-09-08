using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmConstIDNode__CDefinition : CNmIDValueNode::CDefinition, INmConstIDNode__CDefinition {

  public CNmConstIDNode__CDefinition(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol Value {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xF68AB5F96B99AEEA));
  }


}