using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathMover : IPathSimple {

  public ref CUtlVector PathNodes { get; }
  
  public ref CUtlVector Movers { get; }
  
  public ref CTransform XInitialPathWorldToLocal { get; }
  
}