using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmConstVectorNode__CDefinition : CNmVectorValueNode::CDefinition, INmConstVectorNode__CDefinition {

  public CNmConstVectorNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmConstVectorNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Value {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x78163C736B99AEEA));
  }


}