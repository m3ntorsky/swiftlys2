using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetAABBEntity : ISoundOpvarSetPointEntity {

  
  public ref Vector DistanceInnerMins { get; }
  
  public ref Vector DistanceInnerMaxs { get; }
  
  public ref Vector DistanceOuterMins { get; }
  
  public ref Vector DistanceOuterMaxs { get; }
  
  public ref int AABBDirection { get; }
  
  public ref Vector InnerMins { get; }
  
  public ref Vector InnerMaxs { get; }
  
  public ref Vector OuterMins { get; }
  
  public ref Vector OuterMaxs { get; }
}