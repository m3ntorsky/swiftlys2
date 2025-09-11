using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRagdollComponentUpdater : IAnimComponentUpdater {

  
// CUtlVector< CAnimNodePath >
  public ref CUtlVector RagdollNodePaths { get; }
  
// CUtlVector< CAnimNodePath >
  public ref CUtlVector FollowAttachmentNodePaths { get; }
  
  public ref CUtlVector<int> BoneIndices { get; }
  
  public ref CUtlVector<CUtlString> BoneNames { get; }
  
// CUtlVector< WeightList >
  public ref CUtlVector WeightLists { get; }
  
  public ref CUtlVector<int> BoneToWeightIndices { get; }
  
  public ref float SpringFrequencyMin { get; }
  
  public ref float SpringFrequencyMax { get; }
  
  public ref float MaxStretch { get; }
  
  public ref bool SolidCollisionAtZeroWeight { get; }
}