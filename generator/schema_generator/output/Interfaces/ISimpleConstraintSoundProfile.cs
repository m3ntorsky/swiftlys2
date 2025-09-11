using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISimpleConstraintSoundProfile : ISchemaClass {

  
  public ref SimpleConstraintSoundProfile::SimpleConstraintsSoundProfileKeypoints_t Keypoints { get; }
  
  public ISchemaFixedArray<float> KeyPoints { get; }
  
  public ISchemaFixedArray<float> ReversalSoundThresholds { get; }
}