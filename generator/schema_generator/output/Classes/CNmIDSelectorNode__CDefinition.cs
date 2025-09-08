using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIDSelectorNode__CDefinition : CNmIDValueNode::CDefinition, INmIDSelectorNode__CDefinition {

  public CNmIDSelectorNode__CDefinition(nint handle) : base(handle) {
  }

  public ref CUtlVectorFixedGrowable<short> ConditionNodeIndices {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable<short>>(Schema.GetOffset(0x23876114A144D0F));
  }
  public ref CUtlVectorFixedGrowable<CGlobalSymbol> Values {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable<CGlobalSymbol>>(Schema.GetOffset(0x2387611FBEDDADB));
  }
  public ref CGlobalSymbol DefaultValue {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x2387611BBE0341F));
  }


}