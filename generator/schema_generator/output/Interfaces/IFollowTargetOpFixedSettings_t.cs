using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFollowTargetOpFixedSettings_t : ISchemaClass {

  public ref int BoneIndex { get; }
  
  public ref bool BoneTarget { get; }
  
  public ref int BoneTargetIndex { get; }
  
  public ref bool WorldCoodinateTarget { get; }
  
  public ref bool MatchTargetOrientation { get; }
  
}