using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmPoseNode__CDefinition : CNmGraphNode::CDefinition, INmPoseNode__CDefinition {

  public CNmPoseNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmPoseNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}