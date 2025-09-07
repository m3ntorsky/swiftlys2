using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmConstTargetNode__CDefinition : CNmTargetValueNode::CDefinition, INmConstTargetNode__CDefinition {

  public CNmConstTargetNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmConstTargetNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public INmTarget Value {
    get => new CNmTarget(_Handle + Schema.GetOffset(0xC54E1DF56B99AEEA));
  }


}