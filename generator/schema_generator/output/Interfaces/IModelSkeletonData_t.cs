using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelSkeletonData_t : ISchemaClass {

  
  public ref CUtlVector<CUtlString> BoneName { get; }
  
  public ref CUtlVector<short> Parent { get; }
  
  public ref CUtlVector<float> BoneSphere { get; }
  
  public ref CUtlVector<uint> Flag { get; }
  
  public ref CUtlVector<Vector> BonePosParent { get; }
  
  public ref CUtlVector<QuaternionStorage> BoneRotParent { get; }
  
  public ref CUtlVector<float> BoneScaleParent { get; }
}