using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSkeleton : ISchemaClass {

  
  public ref CGlobalSymbol ID { get; }
  
  public ref CUtlLeanVector<CGlobalSymbol> BoneIDs { get; }
  
  public ref CUtlVector<int> ParentIndices { get; }
  
  public ref CUtlVector<CTransform> ParentSpaceReferencePose { get; }
  
  public ref CUtlVector<CTransform> ModelSpaceReferencePose { get; }
  
  public ref int NumBonesToSampleAtLowLOD { get; }
  
  public ref CUtlLeanVector<NmBoneMaskSetDefinition_t> MaskDefinitions { get; }
  
  public ref CUtlLeanVector<CNmSkeleton::SecondarySkeleton_t> SecondarySkeletons { get; }
  
  public ref bool IsPropSkeleton { get; }
}