using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSkeleton : ISchemaClass {

  
  public ref CGlobalSymbol ID { get; }
  
  public ISchemaUntypedField BoneIDs { get; }
  
  public ref CUtlVector<int> ParentIndices { get; }
  
  public ref CUtlVector<CTransform> ParentSpaceReferencePose { get; }
  
  public ref CUtlVector<CTransform> ModelSpaceReferencePose { get; }
  
  public ref int NumBonesToSampleAtLowLOD { get; }
  
  public ISchemaUntypedField MaskDefinitions { get; }
  
  public ISchemaUntypedField SecondarySkeletons { get; }
  
  public ref bool IsPropSkeleton { get; }
}