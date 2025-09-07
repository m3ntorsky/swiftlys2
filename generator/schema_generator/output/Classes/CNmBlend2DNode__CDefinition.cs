using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmBlend2DNode__CDefinition : CNmPoseNode::CDefinition, INmBlend2DNode__CDefinition {

  public CNmBlend2DNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmBlend2DNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVectorFixedGrowable< int16, 5 > SourceNodeIndices {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< int16, 5 >>(Schema.GetOffset(0x965A04D8E90F1FE1));
  }
  public ref short InputParameterNodeIdx0 {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x965A04D85A96A1AF));
  }
  public ref short InputParameterNodeIdx1 {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x965A04D85996A01C));
  }
  public ref CUtlVectorFixedGrowable< Vector2D, 10 > Values {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< Vector2D, 10 >>(Schema.GetOffset(0x965A04D8FBEDDADB));
  }
  public ref CUtlVectorFixedGrowable< uint8, 30 > Indices {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< uint8, 30 >>(Schema.GetOffset(0x965A04D8CF5DEE92));
  }
  public ref CUtlVectorFixedGrowable< uint8, 10 > HullIndices {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< uint8, 10 >>(Schema.GetOffset(0x965A04D8A014D83B));
  }
  public ref bool AllowLooping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x965A04D8FEB26D98));
  }


}