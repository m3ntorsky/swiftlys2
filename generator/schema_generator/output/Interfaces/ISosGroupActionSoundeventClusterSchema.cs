using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionSoundeventClusterSchema : ISosGroupActionSchema {

  
  public ref int MinNearby { get; }
  
  public ref float ClusterEpsilon { get; }
  
  public ref CUtlString ShouldPlayOpvar { get; }
  
  public ref CUtlString ShouldPlayClusterChild { get; }
  
  public ref CUtlString ClusterSizeOpvar { get; }
  
  public ref CUtlString GroupBoundingBoxMinsOpvar { get; }
  
  public ref CUtlString GroupBoundingBoxMaxsOpvar { get; }
}