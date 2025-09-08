using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRenderSkeletonBone_t : ISchemaClass {

  public ref CUtlString BoneName { get; }
  
  public ref CUtlString ParentName { get; }
  
  public ref matrix3x4_t InvBindPose { get; }
  
  public ISkeletonBoneBounds_t Bbox { get; }
  
  public ref float SphereRadius { get; }
  
}