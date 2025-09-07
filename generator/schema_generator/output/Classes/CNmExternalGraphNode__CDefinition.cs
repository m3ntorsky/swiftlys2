using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmExternalGraphNode__CDefinition : CNmPoseNode::CDefinition, INmExternalGraphNode__CDefinition {

  public CNmExternalGraphNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmExternalGraphNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}