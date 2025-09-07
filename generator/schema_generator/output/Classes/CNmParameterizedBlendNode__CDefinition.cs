using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmParameterizedBlendNode__CDefinition : CNmPoseNode::CDefinition, INmParameterizedBlendNode__CDefinition {

  public CNmParameterizedBlendNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmParameterizedBlendNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVectorFixedGrowable< int16, 5 > SourceNodeIndices {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< int16, 5 >>(Schema.GetOffset(0x83A56F31E90F1FE1));
  }
  public ref short InputParameterValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x83A56F31AEA94516));
  }
  public ref bool AllowLooping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x83A56F31FEB26D98));
  }


}