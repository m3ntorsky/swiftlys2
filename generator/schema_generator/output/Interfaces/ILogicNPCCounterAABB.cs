using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicNPCCounterAABB : ILogicNPCCounter {

  
  public ref Vector DistanceOuterMins { get; }
  
  public ref Vector DistanceOuterMaxs { get; }
  
  public ref Vector OuterMins { get; }
  
  public ref Vector OuterMaxs { get; }
}