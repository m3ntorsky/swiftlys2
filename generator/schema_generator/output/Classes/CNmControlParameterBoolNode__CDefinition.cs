using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmControlParameterBoolNode__CDefinition : CNmBoolValueNode::CDefinition, INmControlParameterBoolNode__CDefinition {

  public CNmControlParameterBoolNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmControlParameterBoolNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}