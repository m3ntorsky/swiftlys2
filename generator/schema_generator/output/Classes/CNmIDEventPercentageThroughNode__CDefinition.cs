using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIDEventPercentageThroughNode__CDefinition : CNmBoolValueNode::CDefinition, INmIDEventPercentageThroughNode__CDefinition {

  public CNmIDEventPercentageThroughNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmIDEventPercentageThroughNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x3912E5963F0228C));
  }
  public INmBitFlags EventConditionRules {
    get => new CNmBitFlags(_Handle + Schema.GetOffset(0x3912E59A904315F));
  }
  public ref CGlobalSymbol EventID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x3912E599D798A72));
  }


}