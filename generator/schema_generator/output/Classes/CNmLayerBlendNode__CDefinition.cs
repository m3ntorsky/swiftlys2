using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmLayerBlendNode__CDefinition : CNmPoseNode::CDefinition, INmLayerBlendNode__CDefinition {

  public CNmLayerBlendNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmLayerBlendNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short BaseNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xF9CDDBC5C07C7467));
  }
  public ref bool OnlySampleBaseRootMotion {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF9CDDBC5ABE796B2));
  }
  public ref CUtlLeanVectorFixedGrowable< CNmLayerBlendNode::LayerDefinition_t, 3 > LayerDefinition {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable< CNmLayerBlendNode::LayerDefinition_t, 3 >>(Schema.GetOffset(0xF9CDDBC51AE2DAAF));
  }


}