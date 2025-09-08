using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatCurveEventNode__CDefinition : CNmFloatValueNode::CDefinition, INmFloatCurveEventNode__CDefinition {

  public CNmFloatCurveEventNode__CDefinition(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol EventID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x4512F5A69D798A72));
  }
  public ref short DefaultNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x4512F5A6C14C9521));
  }
  public ref float DefaultValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4512F5A6700AB429));
  }
  public INmBitFlags EventConditionRules {
    get => new CNmBitFlags(_Handle + Schema.GetOffset(0x4512F5A6A904315F));
  }


}