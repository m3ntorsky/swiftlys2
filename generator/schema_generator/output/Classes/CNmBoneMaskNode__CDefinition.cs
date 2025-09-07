using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmBoneMaskNode__CDefinition : CNmBoneMaskValueNode::CDefinition, INmBoneMaskNode__CDefinition {

  public CNmBoneMaskNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmBoneMaskNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol BoneMaskID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xC50CAD4B5F09FD66));
  }


}