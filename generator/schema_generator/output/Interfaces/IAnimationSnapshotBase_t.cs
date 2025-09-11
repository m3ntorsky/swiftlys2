using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationSnapshotBase_t : ISchemaClass {

  
  public ref float RealTime { get; }
  
  public ref matrix3x4a_t RootToWorld { get; }
  
  public ref bool BonesInWorldSpace { get; }
  
  public ref CUtlVector<uint> BoneSetupMask { get; }
  
  public ref CUtlVector<matrix3x4a_t> BoneTransforms { get; }
  
  public ref CUtlVector<float> FlexControllers { get; }
  
  public ref AnimationSnapshotType_t SnapshotType { get; }
  
  public ref bool HasDecodeDump { get; }
  
  public IAnimationDecodeDebugDumpElement_t DecodeDump { get; }
}