using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRenderSkeleton : ISchemaClass {

  public ref CUtlVector Bones { get; }
  
  public ref CUtlVector<int> BoneParents { get; }
  
  public ref int BoneWeightCount { get; }
  
}