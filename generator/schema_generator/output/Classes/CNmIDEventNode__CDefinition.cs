using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIDEventNode__CDefinition : CNmIDValueNode::CDefinition, INmIDEventNode__CDefinition {

  public CNmIDEventNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x6308800E63F0228C));
  }
  public INmBitFlags EventConditionRules {
    get => new CNmBitFlags(_Handle + Schema.GetOffset(0x6308800EA904315F));
  }
  public ref CGlobalSymbol DefaultValue {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x6308800EBBE0341F));
  }


}