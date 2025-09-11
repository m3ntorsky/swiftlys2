using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimSkeleton : ISchemaClass {

  
  public ref CUtlVector<CTransform> LocalSpaceTransforms { get; }
  
  public ref CUtlVector<CTransform> ModelSpaceTransforms { get; }
  
  public ref CUtlVector<CUtlString> BoneNames { get; }
  
  public ref CUtlVector<CUtlVector<int>> Children { get; }
  
  public ref CUtlVector<int> Parents { get; }
  
// CUtlVector< CAnimFoot >
  public ref CUtlVector Feet { get; }
  
  public ref CUtlVector<CUtlString> MorphNames { get; }
  
  public ref CUtlVector<int> LodBoneCounts { get; }
}