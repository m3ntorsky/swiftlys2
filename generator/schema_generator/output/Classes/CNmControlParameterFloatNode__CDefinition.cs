using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmControlParameterFloatNode__CDefinition : CNmFloatValueNode::CDefinition, INmControlParameterFloatNode__CDefinition {

  public CNmControlParameterFloatNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmControlParameterFloatNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}