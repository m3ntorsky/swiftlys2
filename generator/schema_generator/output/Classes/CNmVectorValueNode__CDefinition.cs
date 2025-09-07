using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVectorValueNode__CDefinition : CNmValueNode::CDefinition, INmVectorValueNode__CDefinition {

  public CNmVectorValueNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmVectorValueNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}