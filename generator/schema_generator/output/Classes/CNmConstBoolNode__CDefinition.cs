using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmConstBoolNode__CDefinition : CNmBoolValueNode::CDefinition, INmConstBoolNode__CDefinition {

  public CNmConstBoolNode__CDefinition(nint handle) : base(handle) {
  }

  public ref bool Value {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDEAA315605AAB4AA));
  }


}