using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathMover : IPathSimple {

  
  public ref CUtlVector<CHandle<CMoverPathNode>> PathNodes { get; }
  
  public ref CUtlVector<CHandle<CFuncMover>> Movers { get; }
  
  public ref CTransform XInitialPathWorldToLocal { get; }
}