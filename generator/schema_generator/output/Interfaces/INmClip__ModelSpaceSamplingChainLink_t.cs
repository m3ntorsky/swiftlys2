using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmClip__ModelSpaceSamplingChainLink_t : ISchemaClass {

  
  public ref int BoneIdx { get; }
  
  public ref int ParentBoneIdx { get; }
  
  public ref int ParentChainLinkIdx { get; }
}