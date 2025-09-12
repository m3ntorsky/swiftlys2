using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkeletonAnimCapture_t : ISchemaClass {

  
  public ref uint EntIndex { get; }
  
  public ref uint EntParent { get; }
  
  public ref CUtlVector<uint> ImportedCollision { get; }
  
  public ref CUtlString ModelName { get; }
  
  public ref CUtlString CaptureName { get; }
  
// CUtlVector< SkeletonAnimCapture_t::Bone_t >
  public ref CUtlVector ModelBindPose { get; }
  
// CUtlVector< SkeletonAnimCapture_t::Bone_t >
  public ref CUtlVector FeModelInitPose { get; }
  
  public ref int FlexControllers { get; }
  
  public ref bool Predicted { get; }
  
// CUtlVector< SkeletonAnimCapture_t::Frame_t >
  public ref CUtlVector Frames { get; }
}