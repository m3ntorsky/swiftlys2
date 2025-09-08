using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkeletonAnimCapture_t : ISchemaClass {

  public ref CEntityIndex EntIndex { get; }
  
  public ref CEntityIndex EntParent { get; }
  
  public ref CUtlVector<CEntityIndex> ImportedCollision { get; }
  
  public ref CUtlString ModelName { get; }
  
  public ref CUtlString CaptureName { get; }
  
  public ref CUtlVector ModelBindPose { get; }
  
  public ref CUtlVector FeModelInitPose { get; }
  
  public ref int FlexControllers { get; }
  
  public ref bool Predicted { get; }
  
  public ref CUtlVector Frames { get; }
  
}