using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmConstFloatNode__CDefinition : CNmFloatValueNode::CDefinition, INmConstFloatNode__CDefinition {

  public CNmConstFloatNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmConstFloatNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Value {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCB1D2D708DFCB984));
  }


}