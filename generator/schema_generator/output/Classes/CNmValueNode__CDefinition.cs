using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmValueNode__CDefinition : CNmGraphNode::CDefinition, INmValueNode__CDefinition {

  public CNmValueNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmValueNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}