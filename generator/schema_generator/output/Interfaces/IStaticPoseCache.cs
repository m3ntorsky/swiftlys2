using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStaticPoseCache : ISchemaClass {

  public ref CUtlVector Poses { get; }
  
  public ref int BoneCount { get; }
  
  public ref int MorphCount { get; }
  
}