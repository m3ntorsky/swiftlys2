using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmBoneWeightList : ISchemaClass {

  public ISchemaUntypedField SkeletonName { get; }
  
  public ref CUtlVector<CGlobalSymbol> BoneIDs { get; }
  
  public ref CUtlVector<float> Weights { get; }
  
}