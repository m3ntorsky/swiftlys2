using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmParameterizedSelectorNode__CDefinition : CNmPoseNode::CDefinition, INmParameterizedSelectorNode__CDefinition {

  public CNmParameterizedSelectorNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmParameterizedSelectorNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlLeanVectorFixedGrowable< int16, 5 > OptionNodeIndices {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable< int16, 5 >>(Schema.GetOffset(0xE1B260B3DA97B15D));
  }
  public ref CUtlLeanVectorFixedGrowable< uint8, 5 > OptionWeights {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable< uint8, 5 >>(Schema.GetOffset(0xE1B260B331D94DB5));
  }
  public ref short ParameterNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xE1B260B366C6F2AB));
  }
  public ref bool IgnoreInvalidOptions {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE1B260B3507C679C));
  }
  public ref bool HasWeightsSet {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE1B260B3EA6127CC));
  }


}