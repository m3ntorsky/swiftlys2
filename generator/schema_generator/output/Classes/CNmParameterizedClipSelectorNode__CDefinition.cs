using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmParameterizedClipSelectorNode__CDefinition : CNmClipReferenceNode::CDefinition, INmParameterizedClipSelectorNode__CDefinition {

  public CNmParameterizedClipSelectorNode__CDefinition(nint handle) : base(handle) {
  }

  public ref CUtlLeanVectorFixedGrowable<int16,5> OptionNodeIndices {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable<int16,5>>(Schema.GetOffset(0xF7011439DA97B15D));
  }
  public ref CUtlLeanVectorFixedGrowable<uint8,5> OptionWeights {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable<uint8,5>>(Schema.GetOffset(0xF701143931D94DB5));
  }
  public ref short ParameterNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xF701143966C6F2AB));
  }
  public ref bool IgnoreInvalidOptions {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF7011439507C679C));
  }
  public ref bool HasWeightsSet {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF7011439EA6127CC));
  }


}